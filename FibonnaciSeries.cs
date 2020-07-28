using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSeries
{
    class fibonacci
    {
        static void Main()
        {
            double a = 0, b = 1, c, i, num;
            Console.WriteLine("\t \t --------------Fibonacci Series-------------- ");
            Console.Write("Enter range: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
                if (c < num)
                {
                    Console.WriteLine(c);
                }
            }
            Console.WriteLine("\n\n\t \t --------------End of program-------------- ");
            Console.ReadLine();
        }
    }
}
