using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_OOP_Game
{
    class Enemy: Character
    {
        //Constructor
        public Enemy(int level)
        {
            this.Name = "CSharpVirus";
            this.Level = level;
            this.IsAlive = true;
            this.Health = 100;
            this.AttackPower = 12;
            this.CritChance = 0.10;
        }
        //Properties
        public string Name { get; set; }
    }
}
