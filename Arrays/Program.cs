using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            basicArray();
            PromptContinue();

            addArray();
            PromptContinue();

            stringArray();
            PromptContinue();

            loopArray();
            PromptContinue();

            shortLoopArray();
            PromptContinue();

            reverseArray();



            PromptForExit();


        }
        private static void basicArray()
        {
            // arrays 
            int[] numbers = new int[5];
            // five elements in the array 
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;


            // print the value of second array 
            Console.WriteLine(numbers[1]);
            Console.ReadLine();

            Console.WriteLine(numbers.Length);
            Console.ReadLine();

        }

        // add to array 
        private static void addArray()
        {
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(numbers.Length);
            Console.ReadLine();

        }

        // string array 
        private static void stringArray()
        {
            string[] names = new string[] { "Eddie0", "Eddie1", "Eddie2", "Eddie3", "Eddie4" } ;
            Console.WriteLine(names.Length);
            Console.ReadLine();
        }

        // loop through array 
        private static void loopArray()
        {
            string[] names = new string[] { "Eddie0", "Eddie1", "Eddie2", "Eddie3", "Eddie4" };

            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            //Console.WriteLine(names.Length);
            //Console.ReadLine();
        }

        // shortloop through array 
        private static void shortLoopArray()
        {
            string[] names = new string[] { "Eddie0", "Eddie1", "Eddie2", "Eddie3", "Eddie4" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            //Console.WriteLine(names.Length);
            //Console.ReadLine();
        }

        // reverse loop array 
        private static void reverseArray()
        {
            string zig = "You can get what  you want out of life" + 
                " if you help enough other people get what they want.";

            // create an array of characterrs
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach(char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }
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
