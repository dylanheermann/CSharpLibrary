using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object Instantiation
            Netflix theOffice = new Netflix(); //format: <class> <newObjectInsideClass> = <newObject> <class>() (?)
            Netflix strangerThings = new Netflix();
            Netflix theItCrowd = new Netflix();

            // Set Object Values
            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 5.0; //theOffice is already instantiated from Netflix class and has all of Netflix class's properties within theOffice

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Horror?"; 
            strangerThings.Rating = 4.6;

            theItCrowd.Name = "The IT Crowd";
            theItCrowd.Genre = "Humour";
            theItCrowd.Rating = 1.5;

            // Calling the methods (invoking, executing functions/methods)
            theOffice.GetSuggestion(); //theOffice was initialized earlier, now GetSuggestion method is being executed
            strangerThings.GetSuggestion();
            theItCrowd.GetSuggestion();

            // Creating a list of Objects
            List<Netflix> favoriteShows = new List<Netflix>();//List<Netflix> is creating a list within Netflix's "favoriteShows" variable, like above.

            favoriteShows.Add(theOffice);//Add theOffice to favoriteShows list.
            favoriteShows.Add(strangerThings); //Add strangerThings to favoriteShows list.
            favoriteShows.Add(theItCrowd);
            //show refers to the above favoriteShows within the List variable (array?).
            foreach (Netflix show in favoriteShows) //show is representing each value within favoriteShows (all 3)
                //is "show" working similarly to "this."  property? "show" refers to each value contained within favoriteShows using the Add function(nameOfShow)
            {
                Console.WriteLine($"Show Name: {show.Name} | Genre: {show.Genre} | Rating: {show.Rating}.");
            }

            Console.ReadLine();
        }
    }
}
