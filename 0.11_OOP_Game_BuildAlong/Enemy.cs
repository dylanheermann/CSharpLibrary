using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_OOP_Game_BuildAlong
{
    class Enemy : Character
    {
        //This is a Constructor.Refers to line 63 in Program.cs.
        public Enemy(string name, int level)//name and level will be "Jay" and hero.Level. Obtained from this:
             //Enemy robot = new Enemy("Jay", hero.Level);
             //giving a side by side visualization there.
        {
            this.Name = name; //Sets name equal to the name used in Program.cs (robot) for example. Pulls from Program.cs.
            this.IsAlive = true; //
            this.Health = 100;//this.Health is the same as Enemy.Health, but it is a method of shortening the code typed.
            //It prevents you from having to type Enemy.Health = 100,
            //Enemy.IsAlive = true;
            //Enemy.Level = level; ETC. ETC.
            //And also putting Enemy in this format of "public Enemy(string name, int level)", (? name of it) makes Enemy contain all
            //these declarations(correct word ?)
            //initializing, declaring, instantiating, interpolation, ...
            this.Level = level; //Not sure I understand why this line is necessary and how it relates to parameters in Enemy.
            this.AttackPower = 8;
            this.CritChance = 0.20;
        }
    }
}
