using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
   
    internal class Program
    {
        //The .Net Framework class library is a collection of classes, each containing methods filled with functionalty
        // that we can utilitize. it's massive so was split into multiple files called .net assemblies 
        //even apps we make are compiling into .net assemblies, bin/debug folder contains additional files to 
        //connect to the compiled executable allowing us to pause and debug line by line
        static void Main(string[] args)
        {
            // Write one string to a text file.
            //string text = "A class is the most powerful data type in C#. Like a structure, " +
                           //"a class defines the data and behavior of the data type. ";
          
            //File.WriteAllText(@"\\Mac\Home\Desktop\SCHOOL\Summer\WriteText.txt", text);

            // https://msdn.microsoft.com/en-us/library/fhd1f0sw(v=vs.110).aspx
            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }
}
