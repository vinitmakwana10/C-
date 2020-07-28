using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Program to place double quotation mark around each word in a string*/
namespace ConsoleAppString
{
    class Practical2
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\n  ----Program to place double quotation mark around each word in a string----");
            Console.Write("\nEnter any String: ");
            String s = Console.ReadLine();
            String[] ch = s.Split(' ');
            Console.WriteLine("\nThe processed output is: ");
            foreach (String wr in ch)
            {
                Console.WriteLine("\"" + wr + "\"");
            }
            Console.WriteLine("\n  ---------------------------End of Program----------------------------------");
            Console.ReadLine();
        }
    }
}
