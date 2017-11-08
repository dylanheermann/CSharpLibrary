using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game_BuildAlong
{
    class Player : Character //Character has all propertities of Player Class
    {
        //Constructor
        //Creating a container for when you call Player
        public Player(string name, Specialization role)
        {
            this.Name = name;//this = Player
            this.Role = role;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }

        public void MakeOverPowered()
        {
            this.Level = 99999999;
            this.AttackPower = 999999999;
            this.CritChance = 1.00;
        }

        //Properties
        public Specialization Role { get; set; }

        //Enums
        public enum Specialization
        {
            HorseMange,
            TrollCat,
            KnightTemplator,
            Demogorg,
            Vampire,
            BovineFrog
        }

        public enum Action
        {
            Attack,
            Run,
            Hide
        }
    }
}
