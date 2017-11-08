using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Netflix
    {
        // Properties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        // Methods 
        public void GetSuggestion()
        {
            if (this.Rating > 3.5)
            {
                Console.WriteLine("This is a pretty good show.");//this.Rating being the Rating in Netflix class
            }
            else
            {
                Console.WriteLine("Don't waste your time.");
            }
        }


    }
}
