using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {

        public int Health { get; set; }
        public int DodgeBuff { get; private set; }
        public bool hasDodgeBuff { get; set; }
        public bool isDead { get; set; }
        public int MaxHealth { get; private set; }
        public float strength;

        bool isEasyMode = NewDifficulties.EasyMode;
        bool isHardMode = NewDifficulties.HardMode;

        public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
            //Checks if the player clicked the Easy difficulty button and gives larger health pool if so
            if (isEasyMode)
            {
                MaxHealth = 50;
            }
            //Checks if the player clicked the Hard difficulty button and gives smaller health pool if so
            else if (isHardMode)
            {
                MaxHealth = 15;
            }
            //If the player clicked Normal difficulty button both EasyMode and HardMode are false
            else { MaxHealth = 30; }

            //Checks if the player clicked the Easy difficulty button and gives more strength if so
            if (isEasyMode)
            {
                strength = 4;
            }
            //Checks if the player clicked the Easy difficulty button and gives less strength if so
            else if (isHardMode)
            {
                strength = 2;
            }
            //If the player clicked Normal difficulty button both EasyMode and HardMode are false
            else {  strength = 3; }
      
      Health = MaxHealth;
      DodgeBuff = 0;
      
    }

    public void OnAttack(int amount) {
            //Checks if the player clicked the Easy difficulty button and makes them deal more damage if so
            if (isEasyMode)
            {
                AttackEvent((int)((amount * strength*2) - DodgeBuff));
            }
            //Checks if the player clicked the Hard difficulty button and makes them deal less damage if so
            else if (isHardMode)
            {
                AttackEvent((int)((amount * strength*0.5) - DodgeBuff));
            }
            //If the player clicked Normal difficulty button both EasyMode and HardMode are false
            else { AttackEvent((int)((amount * strength) - DodgeBuff)); }
      
    }

        public void AlterHealth(int amount) {
            Health += amount;
        }

        public void GiveDodgeBuff(int amount) {
          DodgeBuff += amount;
        }

        public void RemoveDodgeBuff()
        {
            DodgeBuff = 0;
        }
    }
}
