using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            for (int i = 1; i <= myWeapons.Length; i++)
            {
                if (myWeapons[i] == null)
                {
                    myWeapons[i] = weapon;
                    switch (i)
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
                    }
                    break;

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

                        default:
                            break;
                    }
                    if (myPotions[i] != null)
                    {
                        break;
                    }

                }
            }
        }

        public void removeWeapon(int index)
        {
            myWeapons[index] = null;
            switch (index)
            {
                case 1:
                    weaponSlot1.BackgroundImage = null;
                    break;
                case 2:
                    weaponSlot2.BackgroundImage = null;
                    break;
                case 3:
                    weaponSlot3.BackgroundImage = null;
                    break;
                case 4:
                    weaponSlot4.BackgroundImage = null;
                    break;
            }
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

        private void selectWeapon(int index)
        {
            if (myWeapons[index] != null)
            {
                Weapon n = myWeapons[index];
                Weapon moveSelected = myWeapons[0];
                
                
                switch (index)
                {
                    case 1:
                        if(moveSelected == null)
                        {
                            weaponSlot1.BackgroundImage = null;
                        }
                        else
                        {
                            weaponSlot1.BackgroundImage = moveSelected.Img;

                        }
                        break;
                    case 2:
                        if (moveSelected == null)
                        {
                            weaponSlot2.BackgroundImage = null;
                        }
                        else
                        {
                            weaponSlot2.BackgroundImage = moveSelected.Img;

                        }
                        break;
                    case 3:
                        if (moveSelected == null)
                        {
                            weaponSlot3.BackgroundImage = null;
                        }
                        else
                        {
                            weaponSlot3.BackgroundImage = moveSelected.Img;

                        }
                        break;
                    case 4:
                        if (moveSelected == null)
                        {
                            weaponSlot4.BackgroundImage = null;
                        }
                        else
                        {
                            weaponSlot4.BackgroundImage = moveSelected.Img;

                        }
                        break;

                }
                selectedWeaponSlot.BackgroundImage = n.Img;
                myWeapons[0] = n;
                myWeapons[index] = moveSelected;
            }
            else
            {
                if (myWeapons[0] != null)
                { 
                    Weapon moveSelected = myWeapons[0];
                    myWeapons[index] = moveSelected;
                    switch(index)
                    {
                        case 1:
                            weaponSlot1.BackgroundImage = moveSelected.Img;
                            break;
                        case 2:
                            weaponSlot2.BackgroundImage = moveSelected.Img;
                            break;
                        case 3:
                            weaponSlot3.BackgroundImage = moveSelected.Img;
                            break;
                        case 4:
                            weaponSlot4.BackgroundImage = moveSelected.Img;
                            break;
                    }
                    myWeapons[0] = null;
                    selectedWeaponSlot.BackgroundImage = null;
                }
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
            else if(myPotions[i] != null && ((player.Health + myPotions[i].HealingPower) > player.MaxHealth) && player.Health != player.MaxHealth)
            {
                this.player.AlterHealth(player.MaxHealth - player.Health);
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

        private void disposePotionbtn1_Click(object sender, EventArgs e)
        {
            removePotion(0);
        }

        private void disposePotionbtn2_Click(object sender, EventArgs e)
        {
            removePotion(1);
        }

        private void disposePotionbtn3_Click(object sender, EventArgs e)
        {
            removePotion(2);
        }

        private void disposePotionbtn4_Click(object sender, EventArgs e)
        {
            removePotion(3);
        }

        private void disposePotionbtn5_Click(object sender, EventArgs e)
        {
            removePotion(4);
        }

        private void selectWeapon1btn_Click(object sender, EventArgs e)
        {
            selectWeapon(1);
        }

        private void selectWeapon2btn_Click(object sender, EventArgs e)
        {
            selectWeapon(2);
        }

        private void selectWeapon3btn_Click(object sender, EventArgs e)
        {
            selectWeapon(3);
        }

        private void selectWeapon4btn_Click(object sender, EventArgs e)
        {
            selectWeapon(4);
        }

        private void disposeWeapon1btn_Click(object sender, EventArgs e)
        {
            removeWeapon(1);
        }

        private void disposeWeapon2btn_Click(object sender, EventArgs e)
        {
            removeWeapon(2);
        }

        private void disposeWeapon3btn_Click(object sender, EventArgs e)
        {
            removeWeapon(3);
        }

        private void disposeWeapon4btn_Click(object sender, EventArgs e)
        {
            removeWeapon(4);
        }
    }
}
