using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsDictionarys
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            Dictionary<string, string> awardWinners = new Dictionary<string, string>();//Keep note of the syntax in this Dictionary.<string, string> (NO COMMA) awardWinners = ...
            awardWinners.Add("2006", "Happy Feet");
            awardWinners.Add("2007", "Ratatouille");
            awardWinners.Add("2008", "Wall-E");
            awardWinners.Add("2009", "UP");
            awardWinners.Add("2010", "Toy Story 3");

            //foreach (var movie in awardWinners)
            //{
            //    Console.WriteLine($"{movie.Key} the winner was {movie.Value}");
            //}








            //SILVER
            Dictionary<string, string[]> awardNominees = new Dictionary<string, string[]>()//Dictionary is a built-in class.
            {//the <string, string[]>   gives the array an unfixed number of values. There will always be at least one value, but string[] can be any length. It can vary.
                { "2006", new string[] { "Happy Feet", "Cars", "Monster House"} },
                { "2007", new string[] { "Ratatouille", "Persepolis", "Surf's Up"} },
                { "2008", new string[] { "Wall-E", "Bolt", "Kung Fu Panda"} },
                { "2009", new string[] { "Up", "Mr. Fantastic Fox", "Coraline"} },
                { "2010", new string[] { "Toy Story 3", "How to Train Your Dragon", "The Illusionist"} }
            };

            //foreach (var nominee in awardNominees)
            //{
            //    Console.WriteLine($"Nominees for {nominee.Key}: {nominee.Value[0]}, {nominee.Value[1]}, {nominee.Value[2]}");
            //}







            //GOLD
            bool run = true;

            while (run)
            {
                Console.WriteLine("Enter a year: ");
                string inputYear = Console.ReadLine();

                if (awardWinners.ContainsKey(inputYear) && awardNominees.ContainsKey(inputYear)) //if awardWinners contains a value for Key within inputYear AND if awardNomminees contains a vlue for Key within inputYear 
                {
                    Console.WriteLine("To show winner, enter 'winner'. \n" +
                        "To show nominees, enter 'nominees'. \n" +
                        "To end the application, enter 'stop'.");
                    string operation = Console.ReadLine().ToLower();//asking for user input
                    switch (operation)
                    {//3 cases and a default. winner
                        case "winner":
                            Console.WriteLine($"The winner of the {inputYear} was {awardWinners[inputYear]}\n\n");
                            break;
                        case "nominees":
                            string nominees = String.Join(", ", awardNominees[inputYear]);
                            Console.WriteLine($"The nominees of the {inputYear} were: {nominees}.\n\n");
                            break;
                        case "stop":
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Sorry, that's not a valid input.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a year between 2006 and 2010. \n\n");
                }
            }


        }
    }
}
