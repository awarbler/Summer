using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    internal class Program
    {
        // car lot 

        static void Main(string[] args)
        {
            // create a new instance of the car class
            Car myCar = new Car();

            // set properties of Car or hard code properties
            myCar.Make = "Oldsmobile";
            myCar.Model = "cutlas supreme";
            myCar.Year = 1986;
            myCar.Color = "silver";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);
            Console.ReadLine();

            // using a class within the same program 
            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}",value); 

            // another way to determine car value and how to call it
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());


            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car) // upper c is class 
        {
            decimal carValue = 100.0M;
            // someday I might look up the care
            // online webservice to get more 
            // acurate value 
            return carValue;
        }
    }

    // create a class that will hold in on big bucket 
    // define it and then create an instance 
    // class a blueprint 

    class Car
    { 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    

        // method inside another class 
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;

        }
    }

}

