using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HelloWorld();
            // Console.ReadLine();
            HelperMethod();
            Console.ReadLine();
        }

        // create a new method helloWorld to display an simple method
        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        /*goal is to break this down into methods to make code smaller and 
         * eliminate duplicate code.
         * make reverse method to get rid of duplicate code
         * comment out code to see what works after reverseString is completed
         *      to see if it works starting after first name. 
         * once is works make it a reusable method
         
         */
        private static void HelperMethodBefore() 
        {
            //before using helper methods

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            char[] fNameArray = fName.ToCharArray();
            Array.Reverse(fNameArray);

            char[] lNameArray = lName.ToCharArray();
            Array.Reverse(lNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in fNameArray)
            {
                result += item;
            }

            foreach (char item in lNameArray)
            {
                result += item;
            }

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            Console.ReadLine();
        }

        /* eliminate duplicate code because it can cause bugs
         * same code multiply times it makes it harder for changes in the software
        * reduce our need to copy and paste 
        * give method what we are trying to accomplish 
        * to make it easier to ascertain  
        * simply the readablilty of the code - 
        * reduce code to improve the readability
        * strive to make code readable clean and clear and perform well 
        */
        private static void HelperMethod()
        {
            //before using helper methods gathering info from person. 

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            // retrieve the return value from reverseString?
            // display results passing in the 
            DisplayResult(ReverseString(fName),
                ReverseString(lName), ReverseString(city));

            // add a break by using writeline
            Console.WriteLine();

            /*
             * call overload method - this is a duplicate method that does the same thing and passes 
             * different information
             * DisplayResult(ReverseString(fName) + " " +
                ReverseString(lName) + " " + ReverseString(city));
            */

            Console.ReadLine();
            /*
                        // reverse operations 

                        char[] fNameArray = fName.ToCharArray();
                        Array.Reverse(fNameArray);

                        char[] lNameArray = lName.ToCharArray();
                        Array.Reverse(lNameArray);

                        char[] cityArray = city.ToCharArray();
                        Array.Reverse(cityArray);

                        // print out results 

                        string result = "";

                        foreach (char item in fNameArray)
                        {
                            result += item;
                        }

                        foreach (char item in lNameArray)
                        {
                            result += item;
                        }

                        foreach (char item in cityArray)
                        {
                            result += item;
                        }

                        Console.WriteLine("Results: " + result);
                       ;*/
        }

        /* 
         * copy first reverse and paste in reverse string 
         * paste 
         * hard code message to see if it works
         * change firstname to message
         * write each item to console
         * once it works 
         * then make reverse string as a reusable assign an input parameter
         * caller can pass in the string that we want reversed
         * create an input pareamenter and data type 
         * and a moniker or a name that allows a value inside of method
         */
        // reverseString should accept an input string
        // and then return or report back giving results to caller
        // does not use void(doesnt report back) it needs to use a string(reports back) 
        // return string back 
        private static string ReverseString(string message)
        {
            /* one way to reverse string 
             * Reverse the string 
             * 1.  hard code the message 
             * string message = "Hello World"; 
             * // deleted once we see hard code works
             * change firstname to message */

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            // dont do for loop ::
            // easy way to do the same thing as a for loop to return use helper method
            // use string class concat method and pass in the array of individual characters. 
            return String.Concat(messageArray);
        }

        // display result will display the results on the console screen
        // we will retrieve the information returned from reversedString
        private static void DisplayResult(
            string reversedFName, string reversedLName, string reversedCity )
        {
            Console.Write("Results: ");
            // use string format to add a space.
            Console.Write(String.Format("{0} {1} {2}",
                reversedFName,
                reversedLName,
                reversedCity));
        }
        // overloaded version of displayResult method - use the same name 
        // but the number and data type of input parameter n method definiton
        // what if we want to only call one items not all.
        // must change the signature of the method - paramaters must change
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            // use string format to add a space.
            Console.Write(message);
        }

    }
}
