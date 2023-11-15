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

        private int FireDamage = 2;
        private int IceDamage = 2;
        private bool FirePower;
        private bool IcePower;

        public Image Img { get; set; }


        public Weapon(string name, int damagePower, bool firePower, bool icePower)
        {
            this.FirePower = firePower;
            this.IcePower = icePower;
            this.Name = name;
            if(firePower)
            {
                this.DamagePower = damagePower + FireDamage;

            }
            else
            {
                this.DamagePower = damagePower + IceDamage;

            }
            
        }

    }
}
