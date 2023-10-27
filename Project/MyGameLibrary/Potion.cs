using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Potion
    {
        public string Name { get; set; }
        public int HealingPower { get; set; }
        public string Description { get; set; }

        public Image Img { get; set; }


        public Potion(string name, int healingPower, string description) 
        {
            this.Name = name;
            this.HealingPower = healingPower;
            this.Description = description;
        }

    }
}