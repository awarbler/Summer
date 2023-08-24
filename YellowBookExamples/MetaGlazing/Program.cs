using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaGlazing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Window sizes measured in meters Invalid values:
             * width less than 0.5 metres width greater than 5.0 metres
             * height less than 0.75 metres height greater than 3.0 metres */

            /* if(condition)statement we do if condition is true
             * elsestatement we do if condition is false*/

            // Relational Operators - 2 * ( width + height ) * 3.25

            // Testing the height upper limit
            //  if (height > 3.0) Console.WriteLine("too high");
            //  else Console.WriteLine("not too high");

            int height = 99;
            if (height >= 99)
            {
                Console.WriteLine("it is true");
                Console.WriteLine("Oh yes");
            }
            else
                Console.WriteLine("it is false");
            Console.ReadLine();




        }
    }
}
