using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
   
    public partial class CharacterSelect : Form
    {
        
        public CharacterSelect()
        {
            InitializeComponent();

        }

        public static Bitmap characterPicked;

        private void picBlue_Click(object sender, EventArgs e)
        {
            characterPicked = global::Fall2020_CSC403_Project.Properties.Resources.Blue_Ranger_Idle_Fight;

            Close();
        }

        private void picYellow_Click(object sender, EventArgs e)
        {
           characterPicked = global::Fall2020_CSC403_Project.Properties.Resources.Yellow_Ranger_Idle_Fight;

           Close();
        }

        private void PicBlack_Click(object sender, EventArgs e)
        {
            characterPicked = global::Fall2020_CSC403_Project.Properties.Resources.Black_Ranger_Idle_Fight; 

            Close();
        }

    }
}
