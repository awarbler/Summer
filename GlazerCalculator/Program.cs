﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * ( width + height ) * 3.25;

            glassArea = 2 * (width + height);

            Console.WriteLine($" The length of the wood is{woodLength} feet ");
            Console.WriteLine($" The area of the glass is {glassArea} square meters" );
        }
    }
}
