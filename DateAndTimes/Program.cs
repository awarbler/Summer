using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString()); // take or location and present dates and time 
            //Console.WriteLine(myValue.ToShortDateString()); // display month date year
            //Console.WriteLine(myValue.ToShortTimeString()); // isolate the time of day 
            //Console.WriteLine(myValue.ToLongDateString());// long form version of date 
            //Console.WriteLine(myValue.ToLongTimeString()); // longer version of time 

            // date time math 
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // add days 
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());// add hours 
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());// subtract days 

            //Console.WriteLine(myValue.Month); // get month

            //DateTime myBirthday = new DateTime(1969, 12, 7); // get certain date 
            //Console.WriteLine(myBirthday.ToShortDateString()); // 

            DateTime myBirthday = DateTime.Parse("12/7/1969"); // string to date 
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);// span of time subtract current date 
            Console.WriteLine(myAge.TotalDays); // get total day 

            Console.ReadLine();
        }
    }
}
