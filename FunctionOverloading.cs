using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practs
{
    class functionoverloading
    {

        void area(int s)
        {
            int area1 = s * s;
            Console.WriteLine("Area of square is: " + area1);
        }
        void area(int l, int b)
        {
            int area1 = l * b;
            Console.WriteLine("Area of rectangle is: " + area1);
        }
        void area(int a, int b, int c)
        {
            int area1 = a * b * c;
            Console.WriteLine("Area of uninvented shape is: " + area1);
        }
        static void Main()
        {
            functionoverloading d = new functionoverloading();
            Console.WriteLine("\n  ---------------------Program for function overloading--------------------------");
            d.area(5);
            d.area(10, 5);
            d.area(5, 9, 6);
            Console.WriteLine("\n  ---------------------End of Program--------------------------");
            Console.ReadLine();
        }
    }
}
