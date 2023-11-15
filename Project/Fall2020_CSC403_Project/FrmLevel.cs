using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    List<string> playerMovements = new List<string>();
    private Player player;
    private FrmInventory inventory;
        private Potion potion;
        private Weapon weapon;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmPause frmPause;

    public FrmLevel(FrmInventory inv) {
            // Gives us access to the inventory fields in the main map
            this.inventory = inv;

            // Creates a potion and puts it in the inventory


            // Creates a sword and puts it in the inventory
            //weapon = new Weapon("Sword1", 5, "Sword that does 5 damage");
            //weapon.Img = global::Fall2020_CSC403_Project.Properties.Resources.sword1;
            //inventory.addWeapon(weapon);

            InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      System.Media.SoundPlayer playersound = new System.Media.SoundPlayer(Properties.Resources.power_rangers_theme_instrumental);
      playersound.Play();
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            // Gives the player object an Img and sets up the stats for the inventory
            player.Img = CharacterSelect.characterPicked;
            inventory.displayPlayerStats(player);

            bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
            // Passes the inventory to FrmBattle to be used later
            if (enemy.Health > 0)
            {
                frmBattle = FrmBattle.GetInstance(enemy, inventory);
                frmBattle.Show();
            }

            if (enemy.Health <= 0)
            {
                enemy.Img = Properties.Resources.Skull;
            }

            if (enemy == bossKoolaid && enemy.Health > 0) {
        frmBattle.SetupForBossBattle();
      }

    }
    
    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
   
      switch (e.KeyCode) {
        case Keys.Left:
           player.GoLeft();   
        break;

        case Keys.Right:
            
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;
                // Adds a keybind for the inventory to be opened; the I key
                case Keys.I:
                    inventory.displayPlayerStats(player);
                    inventory.ShowDialog(this);
                    break;

        //Add a case to close the game if the esc key is pressed.
        case Keys.Escape:
          this.Close();
          break;

        //Add a case to open the pause menu if the p key is pressed.
        case Keys.P:
          frmPause = new FrmPause();
          frmPause.Show();
          break;

        default:
          player.ResetMoveSpeed();
         break;
      }
    }


    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        private void ExitGameBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
