using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Player class with an Attack() methods
            // that accepts 3 different sets of parameters
            //
            // for Example:
            // Attack(100) -->                      "Attacked for 100!"
            // Attack(100, "Weapon") -->            "Attacked with Weapon for 100!"
            // Attack(100, "Weapon", #ofTimes) -->  "Attacked with Weapon for 100 #ofTimes, dealing totalDamage!"

            Player me = new Player();
            
            me.Attack(2500);
            me.Attack(1000, "dusty stick");
            me.Attack(500, "Katana", 90);

            //Using returns
            int num1 = 3;
            int num2 = 5;

            int product = num1 * num2;              // equals 15
            int product2 = me.Multiply(num1, num2); // equals 15


        }
    }
}
