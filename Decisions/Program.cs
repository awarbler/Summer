using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            // if there is only one line of code in if statements then we will
            // not need the {}

            if (userValue == "1")
                message = " You won a new car! ";
            else if (userValue == "2")
                message = "You won a new boat";
            else if (userValue == "3")
                message = "You won a new cat";
            else
            {
                message = "Sorry, we didnt understand. ";
                message = message + " you lose";
                // or 
                message += "Loser";
            }


            Console.WriteLine(message);
            Console.ReadLine();

            PromptContinue();

            // run toms game 
            TomsGiveaway();
            PromptContinue();

            // run toms shortened 
            TomGiveShorten();

            // prompt exit 
            PromptForExit();
        }

        // game 2 if statement shorten

        private static void TomsGiveaway()
        {
            Console.WriteLine("Tom's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            // evaluate if equal 1 
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");
            Console.ReadLine();

        }

        private static void TomGiveShorten() 
        {
            Console.WriteLine("Tom's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            // evaluate if equal 1 
            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            // Console.Write(".");


            // use replacement code for the commented out three lines
            Console.WriteLine("You won a {0}.",message);
            Console.ReadLine();

            // use replacement code with two values 
            Console.WriteLine("You enetered: {0}, therefore you won a {1}.", userValue, message); 
            
            Console.ReadLine();

        }

        // create a prompt to exit the screen
        private static void PromptContinue()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Write(Environment.NewLine);
        }

        // create a prompt to exit the screen
        private static void PromptForExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }


    }
}
