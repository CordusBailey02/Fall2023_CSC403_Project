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
        public Image Img { get; set; }


        public Potion(string name) 
        {
            this.Name = name;

            if(name == "LesserHealthPotion")
            {
                this.HealingPower = 5;
            }
            else if(name == "NormalHealthPotion")
            {
                this.HealingPower = 10;
            }
            else
            {
                this.HealingPower = 15;
            }

        }

    }
}