using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        public Potion[] myPotions;
        public Weapon[] myWeapons;
        private Player player;

        public FrmInventory()
        {
            myPotions = new Potion[5];
            myWeapons = new Weapon[5];
            InitializeComponent();
        }

        public void displayPlayerStats(Player player)
        {
            this.player = player;
            // Sets the playerPanel to the image of the player character
            displayPlayerImg(player.Img);

            // Handles the health bar
            displayPlayerHealth(player.Health, player.MaxHealth);

            // Handles the strength bar
            displayPlayerStrength(player.strength, 20);
        }

        private void displayPlayerImg(Image img)
        {
            playerPanel.BackgroundImage = img;
        }

        private void displayPlayerHealth(int health, int maxHealth)
        {
            healthLabel.Text = "Health: " + health.ToString();
            progressBarHealth.Maximum = maxHealth;
            progressBarHealth.Value = health;
        }

        private void displayPlayerStrength(float strength, int max)
        {
            strengthLabel.Text = "Strength: " + strength.ToString();
            progressBarStrength.Maximum = max;
            int stre = (int) strength;
            progressBarStrength.Value = stre;
        }

        public void addWeapon(Weapon weapon)
        {
            for (int i = 0; i < myWeapons.Length; i++)
            {
                if (myWeapons[i] == null)
                {
                    myWeapons[i] = weapon;
                    switch (i+1)
                    {
                        case 1:
                            weaponSlot1.BackgroundImage = weapon.Img;
                            break;
                        case 2:
                            weaponSlot2.BackgroundImage = weapon.Img;
                            break;
                        case 3:
                            weaponSlot3.BackgroundImage = weapon.Img;
                            break;
                        case 4:
                            weaponSlot4.BackgroundImage = weapon.Img;
                            break;
                        case 5:
                            weaponSlot5.BackgroundImage = weapon.Img;
                            break;
                    }

                }
            }
        }

        public void addPotion(Potion potion)
        {
            for(int i = 0; i < myPotions.Length; i++)
            {
                if (myPotions[i] == null)
                {
                    myPotions[i] = potion;
                    switch(i+1)
                    {
                        case 1:
                            potionSlot1.BackgroundImage = potion.Img;
                            break;
                        case 2:
                            potionSlot2.BackgroundImage = potion.Img;
                            break;
                        case 3:
                            potionSlot3.BackgroundImage = potion.Img; 
                            break;
                        case 4:
                            potionSlot4.BackgroundImage= potion.Img;
                            break;
                        case 5:
                            potionSlot5.BackgroundImage= potion.Img;
                            break;
                    }

                }
            }
        }

        public void removeWeapon(Weapon weapon)
        {

        }

        public void removePotion(int index) 
        {
            myPotions[index] = null;
            switch(index+1)
            {
                case 1:
                    potionSlot1.BackgroundImage = null;
                    break;
                case 2:
                    potionSlot2.BackgroundImage = null;
                    break;
                case 3:
                    potionSlot3.BackgroundImage = null;
                    break;
                case 4:
                    potionSlot4.BackgroundImage = null;
                    break;
                case 5:
                    potionSlot5.BackgroundImage = null;
                    break;
            }
        }

        private void closeInv(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usePotion1btn_Click(object sender, EventArgs e)
        {
            generalPotionUpdate(0);
        }

        private void usePotion2btn_Click(object sender, EventArgs e)
        {
            generalPotionUpdate(1);
        }

        private void usePotion3btn_Click(object sender, EventArgs e)
        {
            generalPotionUpdate(2);
        }

        private void usePotion4btn_Click(object sender, EventArgs e)
        {
            generalPotionUpdate(3);
        }

        private void usePotion5btn_Click(object sender, EventArgs e)
        {
            generalPotionUpdate(4);
        }

        private void generalPotionUpdate(int i)
        {
            if (myPotions[i] != null && !((player.Health + myPotions[i].HealingPower) > player.MaxHealth))
            {
                this.player.AlterHealth(myPotions[i].HealingPower);
                displayPlayerHealth(player.Health, player.MaxHealth);
                removePotion(i);
            }
            else if (myPotions[i] != null && player.Health != player.MaxHealth)
            {
                this.player.Health = player.MaxHealth;
                displayPlayerHealth(player.Health, player.MaxHealth);
                removePotion(i);
            }
        }
    }
}
