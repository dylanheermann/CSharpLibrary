using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_AccessModifiers
{
    class Point
    {
        public int X { get; set; }
        private int Y { get; set; }
        private string Password { get; set; }

        public int PointMethod()
        {
            return this.X + this.Y;
        }

        private string GetPassword()
        {
            return this.Password;
        }

        public void Login(string inputPassword)
        {
            if (GetPassword() == inputPassword)
            {
                Console.WriteLine("Login successful");
            }

            Console.WriteLine("Error with Login");
        }

    }
}
