using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{ 

public class NewDifficulties
{
        //Variables to decide difficulty that are chosen by the player in a window on startup
        public static bool EasyMode { get; set; }
        public static bool HardMode { get; set; }
        public NewDifficulties()
	{
        //Makes sure the variables start as false
        EasyMode = false;
        HardMode = false;
    }
}
}
