using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Jay";

            switch (friend) //friend is Jay
            {
                case "jay":
                    Console.WriteLine("Hey Jay.");
                    break;//ends the case "jay"
                case "paul":
                    Console.WriteLine("Paul is pretty cool.");
                    break;//ends the case "paul"
                case "kenn":
                    Console.WriteLine("Silent master Kenn...");
                    break;
                default://The option chosen if none of the case statements are true.
                    Console.WriteLine("I don't know you.");
                    break;
            }//end of switch variable.

            int age = 15;

            //same thing as above but using an int.
            switch (age)
            {
                case 21://if age was 21, then:
                    Console.WriteLine("You can drink alcohol.");
                    break;//only one option.
            }
        }
    }
}
