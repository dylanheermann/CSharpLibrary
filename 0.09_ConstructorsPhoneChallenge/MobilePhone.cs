using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorsPhoneChallenge
{
    class MobilePhone
    {
        //Constructor Bronze
        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        //Constructor Silver
        public MobilePhone(string owner, string make, string model)
        {
            this.Owner = owner;
            this.Make = make;
            this.Model = model;
        }

        //Properties
        public string Owner { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        //Methods
        public void PrintPhone()
        {
            Console.WriteLine($"I own a {this.Make} {this.Model}");
        }

    }
}
