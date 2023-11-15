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
    public partial class FrmPause : Form
    {
        public FrmPause()
        {
            InitializeComponent();
        }

        private void saveGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void restartLvlBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quitGameBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
