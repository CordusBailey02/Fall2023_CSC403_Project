using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
            // Commenting out the line below allows us to customize components in windows forms...
            // We must specify each color for the components or they default to the color of the form
      //Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
            //Here is where the difficulty menu needs to pop up
            DifficultyForm difficulty = new DifficultyForm(); 
      Application.Run(difficulty);
            // Creates the players inventory so that it can accessed in any level that may be added
            FrmInventory inventory = new FrmInventory();
      Application.Run(new FrmLevel(inventory));
    }
  }
}
