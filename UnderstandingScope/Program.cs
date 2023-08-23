using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    internal class Program
    {
        // private field available to all the members of the class 
        private static string k = "";

        static void Main(string[] args)
        {
            // assigning j allows us to access info in the for loop and
            // out of the for loop 
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    // out of scope 
                    string l = i.ToString();
                }
                //Console.WriteLine(l); out of scope 
            }

            Console.WriteLine($"Outside of the for: {j}");
            Console.WriteLine($"Outside of the for: {k}");
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }
        // helper method can get the value of K - k was defined at the class level
        // it is a sibling and accessible to all 
        static void HelperMethod()
        {
            Console.WriteLine($"Value of k from the helpermethod(): {k}");
        }
        // classes should be encapsulated private fields and private methods
        // private method  means it can be called within a class
        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            private string helperMethod()
            {
                return "Hello world!";
            }
        }
    }
}
