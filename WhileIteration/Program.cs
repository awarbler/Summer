using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // display main menu until the value shows false
            // if an express is true and assigned to displaymenu we dont have to check for equallity
            bool displayMenu = true;
            // use a while loop to check for a condition and then break out of 
            // the while loop 
            while (displayMenu) // shorten expression while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        // print out a list of options in form of a menu
        // have main menu return a bool 
        private static bool MainMenu()
        {
            Console.Clear(); // clears the console to keep a clean look 
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Print Numbers"); // chg from option 1 to print game
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumber();
                return true;
            }
            else if (result == "2") 
            { 
                GuessingGame();
                return true;
            }
            else if (result == "3") 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        /*.
         * have read line 
         */
        private static void PrintNumber()
        { 
            Console.Clear(); // clears out the console 
            Console.WriteLine("Print Numbers"); // title of game
            Console.Write("Type a number: "); // get number from user 
            int result = int.Parse(Console.ReadLine()); //  convert string to integer
            int counter = 1; // create a counter 
            while (counter < result + 1) // while the counter is less than result 
            {
                Console.Write(counter); // current value counter 
                Console.Write(" - "); // prints out counter numbers 1 - user input
                counter++; // increase the counter 
            } 
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();// clears out the console 
            Console.WriteLine("Guessing Game"); // name of game
            // create random number between 1 and 10 
            // put eleven because we want to go to 10 
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;// keep track of guesses 
            bool incorrect = true; // keep track if user is correct or not
            do // execute at least one time. 
            {
                Console.WriteLine("Guess a number between 1 and 10"); // instructions to user
                string result = Console.ReadLine(); // retrieve the number / reads user input
                guesses++;
                if (result == randomNumber.ToString()) // iincorrect answer 
                    incorrect = false; // basically if it is true breaks out of do statement
                else
                    Console.WriteLine("Wrong!");
            } while (incorrect); // the user gets another chance to guess the number
            Console.WriteLine("Correct! it took you {0} guesses.", guesses);
            Console.ReadLine() ;
        }

    }
}
