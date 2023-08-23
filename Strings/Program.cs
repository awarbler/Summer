using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use bing.com for more information 

            string myString = "My \"so-called\" life";

            //string myString = "My \"so-called\" life";            //quotes
            //string myString = "What if I needa]nnew line?";      //new line
            //string myString = "Go to your C:\\ drive";         //backslsh
            //string myString = @"Go to your C:\ drive";        //blackslash 2 

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = String.Format("{0:C}", 1234); // :C format like currency format right to left 
            //string myString = String.Format( "{0:N}", 123456789); // :N format it to look like a number decimals and commas
            //string myString = String.Format("Percentage: {0:P}", .1234);// : P value as a percentage
            //string myString = String.Format("Phone Number: {0:(###)-(###)-(####)", 1234567890); // or a custom format ex display a phone number 

            //string myString = ("That summer we took three across the bard "); //substring  

            //myString = myString.Substring(6, 14);// starts at sixth position and 14 characters isolate 
            //myString = myString.ToUpper(); // changes to upper 
            //myString = myString.Replace(" ", "--"); // replace characters 
            //myString = myString.Remove(6, 14); // remove character 6 through 14 

            /*
            myString = String.Format("Length before : {0} -- length after: {1}",
                myString.Length, myString.Trim().Length);
             */
            Console.WriteLine(myString);
            Console.ReadLine();

            // manipulate and use string builder 
            StringBuilder myStrings = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myStrings.Append("--"); // to add to the string 
                myStrings.Append(i);
            }
            Console.WriteLine(myStrings);
            Console.ReadLine();

        }
        
            
        
    }
}
