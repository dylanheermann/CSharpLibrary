using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            string[] favFoods = new string[3]; //favFoods is going to be a string variable with 3 values [0] - [2].

            favFoods[0] = "Ice Cream";
            favFoods[1] = "Creme Fraiche";
            favFoods[2] = "Deconstructed Artichoke";

            foreach (string food in favFoods)//this says that for each value from [0] - [2] that is a string within favFoods, :
            {//Remember that string[3] has 3 values. But it starts at [0] and goes to [2].
                Console.WriteLine(food);//will display favFoods[0] - [2].
            }

            //Silver
            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };//multiple value int, numbers1, = a new int[5 values] of {#, #, #, #, #, #}.
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };

            int[] numbers3 = new int[5]; //not yet initialized. Declared, not initialized.

            //using a for loop to create the array
            for (int i = 0; i < numbers3.Length; i++)//create variable i = 0, while i is less than numbers3.Length (.Length is length of the  array) add 1 to int i.
            {
                numbers3[i] = numbers1[i] + numbers2[i];//numbers3[i] = sum of number1[0] + number2[0] and so on.
            }

            //using a foreach loop to display the array
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }
            //Good question: Does the Program run from namespace down to the end curly brace of namespace, all of those lines inbetween, once, and then run through AGAIN? Referring to the loops, is the entire program run 10 times because of the loops, or does it get stuck on the loops in the first run through the code and repeat if statements 10 times (until the loops are invalid) and then reach the end of the code and stop?
            //I think I answered my question. It reads in sequential order, from line to line. the for(int i = 0; .....) would execute once, then jump down to the foreach loop, execute that, then the Program would jump up to the for statement again and repeat this until they equal 10.

            //GOLD
            int[] randomNumbers = new int[10];
            Random rnd = new Random();//using Random function, create a new random number named "rnd".


            //because the first for (int ...) statement is true, it is executed. then Program skips to the foreach ( int...) statement. Then after the foreach statement is executed, the program jumps back up to the for (int....) statement and executes that again. It is not relevant to the other foreach statement.


            for (int i = 0; i < randomNumbers.Length; i++) //While the .Length of randomNumbers is not greater than 10, its set number of values, add 1 to the count 
                //of random numbers generated. In other words, add 1 to randomNumbers's Length until Length reaches 10.
            {
                randomNumbers[i] = rnd.Next(100);//.Next returns a non-negative random integer that is less than (100).
            }
            //remember that the above just sets a value for randomNumbers[i]. 
            //the foreach statement takes the result of randomNumbers[i] and displays in using console writeline.
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
