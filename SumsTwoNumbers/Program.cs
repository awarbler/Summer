using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers();

            ExecutionTest();
            Console.ReadLine();

          

        }
        private static void AddTwoNumbers()
        {
            Console.WriteLine("This program adds two numbers together");
            Console.Write("First Number : ");
            string number1Text = Console.ReadLine();
            int number1 = int.Parse(number1Text);
            Console.Write("Second Number : ");
            string number2Text = Console.ReadLine();
            int number2 = int.Parse(number2Text);
            int result = number1 + number2;
            Console.WriteLine("Sum is : " + result);
        }

        private static void ExecutionTest()
        {
            int first = 1;
            int second = 2;
            int third = 3;
            int result = first + second;
            result = result * third;
            Console.WriteLine(result);
        }

 


    }
}
