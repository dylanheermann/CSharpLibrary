using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);

            Console.WriteLine($"Area = {newSquare.Area()}");

            //CHALLENGE
            //Create a new 'Cricle' class
            //That inherits from 'Shape'
            //
            //Circle should have a constructor that accepts
            //one parameter, being radius.
            //
            //and implements the Shape.Area() method.
            //
            //Sidenote: Area of circle = Pi*r^2
            //Sidenote: let Pi = 3.14 (or use Math.PI)
            //
            //Feeling frisky?
            //Do the same thing, only this time
            //using triangle
        }
    }
}
