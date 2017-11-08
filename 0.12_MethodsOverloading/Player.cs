using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attacked with {weapon} for {damage}!");
        }

        public int Attack(int damage, string weapon, int hitTimes)
        {
            int totalDamage = damage * hitTimes;
            Console.WriteLine($"Attacked with {weapon} {hitTimes} times for {totalDamage}!");
            return totalDamage;
        }

        //Using return example
        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
