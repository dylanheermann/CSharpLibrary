using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string occupation;

            //Again, we are declaring up here. Only declaring. ^
            //Declaring only does not give a value. You must initialize it.

            //We are not initializing until the next line. That still works. 
            firstName = "Fred";
            lastName = "Rogers";
            occupation = "Tv personality";//You can have spacing in Strings.

            string fullName = firstName + " " + lastName; //making a variable fullName equal to the sum of firstName, " " , and lastName.
            Console.WriteLine(fullName); //writing to the console fullName.

            Console.WriteLine("Hello, my name is " + fullName + ". I am a " + occupation + ".");

            //String Interpolation
            Console.WriteLine("Hello, my name is {0}. I am a {1}.", fullName, occupation); //Interpolation can be used two ways. {0} {1} , variableName, variableName,
            //OR $"Hello, my name is {fullName}. I am an {occupation}.
            //The difference is the first is probably more complicated and results in more errors if not careful. You also have to type {number of variable} AND {variable} instead of just {variable}

            Console.WriteLine($"Hello, my name is {fullName}. I am a {occupation}.");

        }
    }
}
