using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _0._11_OOP_Game_BuildAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            //This will be used later
            SpeechSynthesizer synth = new SpeechSynthesizer(); //pull SpeechSynthesis from above "using System.Speech.Synthesis"
            //and name variable synth. It is a new instance of SpeechSynthesizer();.

            //Prompt for player information
            Console.WriteLine("Hello, wanderer...\n"+
                              "What be thy name?");
            string inputName = Console.ReadLine();//inputName value is received from Console.ReadLine();

            Console.Clear();//Clear the console for clarity and clean-ness

            Console.WriteLine($"Nice to meet you, {inputName}."); //Write to console using string interpolation ( $ ) {inputName}.
            Thread.Sleep(1000);//Force the console to sleep for 1 second.
            Console.WriteLine("\nWhat's your specialization friend?\n" +//Ask the user for their specialization. Give 6 choices.
                "0: Horse Mange\n" +//+ sign to include this all in one writeline, \n skips a line for spacing purposes.
                "1: Troll Cat\n" +
                "2: Knight Templator\n" +
                "3: Demogorg\n" +
                "4: Vampire\n" +
                "5: Bovine Frog");
            //Get value user provided by converting string to int
            int inputSpec = Int32.Parse(Console.ReadLine()); //Without this line, inputSpec would be a string, which is invalid for the variableType.

            //Perform explicit cast from
            //int to Specialization enum type
            Player.Specialization inputSpecialization = (Player.Specialization)inputSpec;
            //Pull from Player class's enum Specialization{ }. It has 6 options that are valid. 0-5 user input.
            Console.WriteLine($"Ahh... a {inputSpecialization}, an interesting choice.");
            //using string interpolation again. $ does it. 
            //Create new Player object
            Player hero = new Player(inputName, inputSpecialization);
            //Create hero variable. Pull from Player class, pass attributes inputName and inputSpecialization to hero.
            Console.Clear(); //Clear console again for cleanness.

            Console.WriteLine($"Your journey begins here {hero.Name}, the {hero.Role}");//String interpolating again. $
            //{hero.Name} is taking Name from Character, which was set in that class.
            Thread.Sleep(2000); //pause for 2 seconds
            Console.Clear(); //clear again

            //Setting up for first battle
            Console.WriteLine("A shady figure appears..."); //narrative
            Thread.Sleep(1500); //Sleep for 1.5 sec

            Console.WriteLine($"You're going down {hero.Name}"); //String interpolation, writing to console to
            //remind user of their name. 
            synth.Speak($"You're going down {hero.Name}, the {hero.Role}"); //String interpolation
            Thread.Sleep(1000); //Sleep 1 sec

            Enemy robot = new Enemy("Jay", hero.Level); //Create a new enemy named robot, using Enemy class. 
            Console.WriteLine("BATTLE INSTANTIATED!");
            synth.Speak("BATTLE INSTANTIATED!");

            //Battle loop
            while (hero.IsAlive && robot.IsAlive)
            {
                Console.Clear();
                Console.WriteLine($"{hero.Name}'s Health: {hero.Health}\n" +
                                  $"{robot.Name} Health: {robot.Health}\n\n");
                Console.WriteLine("=======================\n" +
                                  "         ACTIONS   \n" +
                                  "=======================");
                Console.Write("0: Attack\n" +
                              "1: Run\n" +
                              "2: Hide\n");
                int inputAction = Int32.Parse(Console.ReadLine()); //converts inputAction to int (why is this necessary?)
                Player.Action heroAction = (Player.Action)inputAction; //set Player's Action to heroAction. gets heroAction from input from user.

                //Handle hero action
                switch (heroAction)//switch case... determined by (heroAction)'s value. 
                {
                    case Player.Action.Attack://If player's Action is to Attack (0)
                        //Generate attacks
                        int heroAttack = hero.Attack();//then set hero's attack value to hero.Attack() (defined within Player class)
                        int robotAttack = robot.Attack(); //set robot's attack value to robot.Attack() (defined within Enemy class)

                        //Adjust health values
                        hero.Health -= robotAttack;//Subtract hero.Health by value of robotAttack
                        robot.Health -= heroAttack;//Subtract hero.Health by value of heroAttack

                        //Display attack dialogues in the console
                        Console.Clear();
                        Console.WriteLine("====================================\n" +
                                         $"{hero.Name} Deals {heroAttack} to {robot.Name}\n" +//Display: hero Deals hero's attackpower to robot.
                                          "====================================\n");
                        Thread.Sleep(1000);
                        Console.WriteLine("====================================\n" +
                                         $"{robot.Name} Deals {robotAttack} to {hero.Name}\n" +//Display: Same as above for robot to hero.
                                          "====================================\n");
                        Thread.Sleep(1500);
                        break;//End of this case.
                    case Player.Action.Run://If player's action is to run
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to make a run for it!");
                        Thread.Sleep(1500);
                        synth.Speak("Where do you think you're going?!");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} pulls {hero.Name} back into the fight!");//Unsuccessful run away, always.
                        break;
                    case Player.Action.Hide:
                        Console.Clear();
                        Console.WriteLine($"{hero.Name} attempts to hide...");
                        Thread.Sleep(1500);
                        synth.Speak($"You can't hide from me {hero.Role}");
                        Console.Clear();
                        Console.WriteLine($"{robot.Name} found {hero.Name}!");
                        break;
                    default://If user does not follow entering 0,1,2, do this by default
                        Console.WriteLine("Enter 0, 1, or 2 to perform an action!");
                        synth.Speak("I know I make computers slow, but this is just ridiculous!");
                        Thread.Sleep(2000);
                        break;
                }

                //Check to see if anyone is dead
                if (hero.Health < 0)
                {
                    hero.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine($"{robot.Name} has defeated {hero.Name}!");//Enemy class's Name has defeated Player class's Name.
                    Thread.Sleep(1000);
                    synth.Speak("Defeating you was exclamation mark difficult. hahahahahahah.");//robot wins
                }
                if (robot.Health < 0)
                {
                    robot.IsAlive = false;
                    Thread.Sleep(2000);
                    Console.WriteLine($"{hero.Name} has defeated {robot.Name}!");
                    Thread.Sleep(1000);
                    synth.Speak("What!?!?! NOOOOOOOOOOOOOOOO!");
                }
            }
        }
    }
}
