using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            byte myByte = 255; // range: 0 - 255

            int number1 = 15;

            float myFloat = 3.14f;

            double myDouble = 2.54;

            decimal myDecimal = 3.14159M; // What does the M do? Why is it needed?

            char myLetter = 'A';

            string myName = "Jay";

            bool myTruth = true;

            // NOTES
            // Declaration
            // <type> <variableName> <optional initializer>;
            int age; //type: int // variableName: age; not yet initialized
            string country; //Declared but never used

            // Initialization
            age = 41; //This is used to show the age variable being overwritten later in the program. 
            Console.WriteLine(age); //right here it is 41 when displayed
            age = 42; //we overwrite age value to 42
            Console.WriteLine(age); //display age value in the console. cw tab tab
            Console.Beep(); //Makes a beep noise (how many seconds?)
            Console.ReadLine(); //Reads for an input. When pressing enter, closes program.


        }//end of void Main statement
    }//end of class program
}
