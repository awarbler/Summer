using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basicForLoop();

            
            breakForLoop();


            PromptForExit();

        }

        private static void basicForLoop()
        {
            // for loops until it is true
            // declare a variable 
            // write the line each time we go through it 
            // add one to i each time 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            PromptContinue();
        }

        private static void breakForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if( i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }
            Console.ReadLine();
            PromptContinue();
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
