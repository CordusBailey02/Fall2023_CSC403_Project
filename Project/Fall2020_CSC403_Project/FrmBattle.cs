using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Linq;

namespace Fall2020_CSC403_Project {
    public partial class FrmBattle : Form {
        public static FrmBattle instance = null;
        public bool canClose = false;
        private Enemy enemy;
        private Player player;
        private FrmInventory inventory;
        //Create object for the Death Screen form.
        private FrmDeathScreen frmDeathScreen;

        private FrmBattle() {
            InitializeComponent();
            player = Game.player;
            // Registers the event handler for this function to close the window
            this.FormClosing += handleClosingForm;
        }

        public void Setup(FrmInventory inv) {
            // Gives us access to the inventory from FrmBattle
            inventory = inv;

            // Counts the number of potions in the inventory.myPotions[]; i.e. not null
            // Sets the label in FrmBattle to display remaining potions
            int result = inventory.myPotions.Count(s => s != null);
            labelPotionRemain.Text = "Potions Remaining: " + result;

            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            picBossBattle.Visible = false;
            
            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
        }

        public void SetupForBossBattle() {
            picBossBattle.Location = Point.Empty;
            picBossBattle.Size = ClientSize;
            picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();

            tmrFinalBattle.Enabled = true;
        }

        public static FrmBattle GetInstance(Enemy enemy, FrmInventory inv) {
            if (instance == null) {
                instance = new FrmBattle();
                instance.enemy = enemy;
                // Passes the inv to Setup so we can access it later
                instance.Setup(inv);
            }
            return instance;
        }

        private void UpdateHealthBars() {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private void btnLightAttack_Click(object sender, EventArgs e) {
            player.OnAttack(-4);
            if (enemy.Health > 0) {
                  enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            // if the player has a dodge buff then remove it for the next turn
            player.RemoveDodgeBuff();
            if(player.Health <= 0 && (enemy.Health > 0 || enemy.Health < 0))
            {
                instance = null;
                canClose = true;
                Close();
                frmDeathScreen = new FrmDeathScreen();
                frmDeathScreen.Show();
            }
            else if (player.Health > 0 && enemy.Health <= 0) {
                instance = null;
                canClose = true;
                Close();
            }
        }

        private void btnHeavyAttack_Click(object sender, EventArgs e) {

            Random random = new Random();
            int chance = random.Next(11);
            if (chance >= 8) 
            {
                player.OnAttack(-6);
                if (enemy.Health > 0)
                {
                    enemy.OnAttack(-2);
                }

                UpdateHealthBars();
                // if the player has a dodge buff then remove it for the next turn
                player.RemoveDodgeBuff();
                if (player.Health <= 0 && (enemy.Health > 0 || enemy.Health < 0))
                {
                    instance = null;
                    canClose = true;
                    Close();
                    frmDeathScreen = new FrmDeathScreen();
                    frmDeathScreen.Show();
                }
                else if (player.Health > 0 && enemy.Health <= 0)
                {
                    instance = null;
                    canClose = true;
                    Close();
                }
            }
            // Lets the enemy still attack the player if the heavy attack wasn't successful
            enemy.OnAttack(-2);
            UpdateHealthBars();
            if (player.Health <= 0 && (enemy.Health > 0 || enemy.Health < 0))
            {
                instance = null;
                canClose = true;
                Close();
                frmDeathScreen = new FrmDeathScreen();
                frmDeathScreen.Show();
            }
            else if (player.Health > 0 && enemy.Health <= 0)
            {
                instance = null;
                canClose = true;
                Close();
            }
        }

        private void btnDodge_Click(object sender, EventArgs e) {
            Random random = new Random();
            int chance = random.Next(11);
            if(chance >= 7) 
            {
                player.GiveDodgeBuff(2);
                // Prevents Health from being set higher than the max health
                if(player.Health < player.MaxHealth)
                {
                    player.AlterHealth(1);
                }
            }
            else if (enemy.Health > 0) 
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0 && (enemy.Health > 0 || enemy.Health < 0))
            {
                instance = null;
                canClose = true;
                Close();
                frmDeathScreen = new FrmDeathScreen();
                frmDeathScreen.Show();
            }
            else if (player.Health > 0 && enemy.Health <= 0)
            {
                instance = null;
                canClose = true;
                Close();
            }
        }

        private void btnFlee_Click(object sender, EventArgs e) {
            player.RemoveDodgeBuff();
            instance = null;
            canClose= true;
            Close();
        }

        private void EnemyDamage(int amount) {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount) {
            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e) {
            picBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

        private void handleClosingForm(object sender, FormClosingEventArgs e)
        {
            if (canClose == false && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {
            // Uses the potions from let to right in the invetory by looping through myPotions[]
            for(int i = 0; i < inventory.myPotions.Length; i++)
            {
                // Finds the potion by finding an instance that isn't null
                if (inventory.myPotions[i] != null)
                {
                    // Gets the healing power of the potion
                    Potion pot = inventory.myPotions[i];
                    int healthAdd = pot.HealingPower;
                    // Prevents the potion from adding more than Max player health
                    if(!((player.Health + healthAdd) > player.MaxHealth))
                    {
                        // Adds health to player, removes potions, updates potion count, then updates healthbars
                        player.AlterHealth(healthAdd);
                        updatePotions(i);
                    }
                    else if(player.Health != player.MaxHealth)
                    {
                        player.Health = player.MaxHealth;
                        updatePotions(i);
                        
                    }
                    break;
                }
            }
        }

        private void updatePotions(int i)
        {
            inventory.removePotion(i);
            int result = inventory.myPotions.Count(s => s != null);
            labelPotionRemain.Text = "Potions Remaining: " + result;
            UpdateHealthBars();
        }
    }
}
