﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {

        public int Health { get; private set; }
        public int DodgeBuff { get; private set; }
        public bool hasDodgeBuff { get; set; }
        public int MaxHealth { get; private set; }
        private float strength;

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
          MaxHealth = 20;
          strength = 2;
          DodgeBuff = 0;
          Health = MaxHealth;
        }

        public void OnAttack(int amount) {
          AttackEvent((int)((amount * strength) - DodgeBuff));
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
