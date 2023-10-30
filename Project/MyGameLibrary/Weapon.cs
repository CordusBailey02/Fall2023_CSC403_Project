using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Weapon
    {
        public string Name { get; set; }
        public int DamagePower { get; set; }
        public string Description { get; set; }

        public Image Img { get; set; }


        public Weapon(string name, int damagePower, string description)
        {
            this.Name = name;
            this.DamagePower = damagePower;
            this.Description = description;
        }

    }
}
