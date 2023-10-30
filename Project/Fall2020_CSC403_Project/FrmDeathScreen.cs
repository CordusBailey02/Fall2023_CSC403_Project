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
    //This form will pop up when the player's health reaches zero.
    //The player will be given two option to either restart the game or exit the game.
    public partial class FrmDeathScreen : Form
    {
        //Method to initialize the form.
        public FrmDeathScreen()
        {
            InitializeComponent();
        }

        //Method to close the entire game once the Quit Game button is clicked.
        private void QuitGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Method to restart the entire game once the Restart Level button is clicked.
        private void RestrtLvlBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
