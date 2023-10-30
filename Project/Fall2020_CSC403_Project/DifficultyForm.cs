using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class DifficultyForm : Form
    {
        //Allows the button clicks to alter the difficulty variables
        NewDifficulties newDifficulties = new NewDifficulties();
        
        
        public DifficultyForm()
        {
            InitializeComponent();
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {

        }

        //Makes EasyMode variable true if player clicks Easy difficulty button
        private void easyMode_Click(object sender, EventArgs e)
        {
            NewDifficulties.EasyMode = true;
            this.Close();
        }

        //Ignores the difficulty variables if player clicks Normal difficulty button
        private void normalMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Makes HardMode variable true if player clicks Hard difficulty button
        private void hardMode_Click(object sender, EventArgs e)
        {
            NewDifficulties.HardMode = true;
            this.Close();
        }

        //BattleCharacter battleCharacter = new BattleCharacter(diffModifier);
    }
}
