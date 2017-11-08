using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) //initialize int i = 1, while i less than or equal to 100, add value +1 to i.
            {
                if (i % 15 == 0) //If the remainder of i divided by 15 is 0: 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)//If the remainder of i divided by 5 is 0,
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)//If the remainder of i divided by 3 is 0,
                {
                    Console.WriteLine("Fizz");
                }
                else//if none of the above conditions are met, just write i value to console.
                {
                    Console.WriteLine(i);
                }
            }


            // using ternary
            //much shorter way than writing the if statement
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(
            //        i % 15 == 0 ? "FizzBuzz" : // : signifies "or"(?)
            //        i % 5 == 0 ? "Buzz" : //if the remainder of i divided by 5 is equal to exactly 0, "Buzz" is written to console.
            //        i % 3 == 0 ? "Fizz" :
            //        i.ToString() //convert i to string at the end
            //    );
            //}
        }
    }
}
