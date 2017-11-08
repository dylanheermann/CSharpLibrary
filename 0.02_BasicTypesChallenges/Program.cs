using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE

            // Declaration
            // <type> <variableName> <optional initializer>;
            int luckyNumber; //is not initalized. Is given a type and variableName.
            string firstName = "Jay";
            string lastName = "Jackson";
            bool isMarried = false; //booleans can only be true or false.
            double Pi = 3.14;

            Console.WriteLine(Pi); //Display Pi value (3.14)
            Console.WriteLine(isMarried); //Display boolean isMarried value (false)

            //SILVER
            string fullName = firstName + " " + lastName; //value of fullName = firstName value + " " (spacing) + lastName value
            //Console.WriteLine(fullName); //Display fullName value to console

            //GOLD
            string birthYear = "1980"; //giving a string an invalid value (?)
            //int year = Convert.ToInt32(birthYear);

            string age = "30"; //giving string an invalid value, must be alphabet a-z
            int numAge = Convert.ToInt32(age); //int numAge = age variable converted to int from string value
            numAge = numAge + 1;

            Console.WriteLine(numAge);
            Console.WriteLine(birthYear);//still works, even without conversion to int? how?



            //Console.WriteLine("I was born in " + year);


        }
    }
}
