using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************
 * Create a new Visual C# Console App using .NET Framework 
 *      project and name it "MyFirstConsoleApplication."
 *      
 * Create two variables to store your values:
 * Your name
 * Your location (state or country)
 * Output two WriteLine statements that display those 
 *      two variables with proper labels
 * (My name is ... , I am from ...) using String Interpolation.
 * Output the current date, but not the current time. (Ex: 04/06/1830)
 * Output the number of days until Christmas this year 
 *      and, of course, apply an appropriate label to that output.
 * Add the program example from section 2.1 in the C# Programming 
 *      Yellow Book by Rob Miles.
 */

namespace MyPracticeConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            // Create an introduction with Name and Location
            GetUserNameAndLocation();

            // Prompt todays date and days to christmas / math
            ChristmasCountdown(DateTime.Now);

            // glazerApp


            
            // Prompt for exit 
            PromptForExit();

            // Practic create the animal 
            //SpawnAnimal();


        }

        // Build out a  method to get name 
        private static void GetUserNameAndLocation()
        {
            // prompt user for name
            Console.WriteLine("What is your name? ");
            // create a variable to readLine Response 
            var introName = Console.ReadLine(); // or person.name = console.readLine

            // prompt user for lovation 
            Console.WriteLine("Where do  you live? ");
            var introLocation = Console.ReadLine();

            var person = new Person
            { 
                Name = introName, 
                Location = introLocation,
            };

            Console.WriteLine($"My name is {introName}, I live in {introLocation}");

            // prompt to conitnue 
            PromptContinue();
        }
        // crate a function to getDate and days to christmas
        private static void ChristmasCountdown(DateTime nowTime) 
        {
            Console.WriteLine($"Today's date is: {nowTime:MM/dd/yyyy}");
            var christmas = new DateTime(nowTime.Year, 12, 25);
            var results = (christmas - nowTime).Days;
            Console.WriteLine($"There are {results} days until Christmas");
            PromptContinue();
        
        }

        // create a function to prompt continue 
        private static void PromptContinue()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
            Console.Write(Environment.NewLine);
        }

        // create a function to prompt for exit
        private static void PromptForExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }


        // Practice build a method to create the animal
        private static void SpawnAnimal()
        {
            Console.WriteLine("Pleasae enter an animal name: ");
            var animalName = Console.ReadLine();
           
            Console.WriteLine("What year was the animal born?");
            var animalBirthYear = Console.ReadLine();

            //Animal animal = new Animal();
            var animal = new Mammal
            {
                Name = animalName,
                BirthYear = Convert.ToInt32(animalBirthYear),
                HasHair = true,
                NumOfLegs = 4
            };
            
            Console.WriteLine(" You have created an Animal with the name of " +  animal.Name + ", that was born on " + animal.BirthYear + " has haiar: " + animal.HasHair +  " . Number of legs: " +
                 animal.NumOfLegs);
        }

       
    }
}
