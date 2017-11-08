using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03_StringsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            //Currency
            double cash = 563.3265;
            Console.WriteLine("{0:C}", cash);
            //"{0:C}" is unicode(?) for $. creates the $ sign using unicode because you can't just put $ in the syntax.

            //Percentage
            double exchangeRate = 0.23;
            Console.WriteLine("{0:#0.##%}", exchangeRate); //converting exchangerate into 23.00 %.
            Console.WriteLine("{0:P}", exchangeRate); //% sign is {0:P}
            
            //Phone Number
            double phoneNumber = 8123648944;
            string formatedPhoneNumber = phoneNumber.ToString("(###) ### - ####"); //## represents each number in phoneNumber.
            //Convert phoneNumber into a string, but use numbers from phoneNumber in a format
            Console.WriteLine(formatedPhoneNumber);
            Console.WriteLine("{0:(###) ### - ####}", phoneNumber); //another way of displaying phoneNumber in correct format without using formatedPhoneNumber.


        }
    }
}
