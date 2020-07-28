using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//interface
namespace Interface
{
    interface area
    {

        float compute(float x, float y);
    }
    class rectangle : area
    {
        public float compute(float x, float y)
        {
            return (x * y);
        }
    }
    class circle : area
    {
        static float pie = 3.14f;
        public float compute(float x, float y)
        {

            return (pie * x * x);
        }
    }
    class interfacetest
    {
        static void Main()
        {
            rectangle r = new rectangle();
            circle c = new circle();
            area a;
            a = r;
            Console.WriteLine("\n  ---------------------Program for interface--------------------------");
            Console.WriteLine("\nArea of rectangle is " + a.compute(10, 20));
            a = c;
            Console.WriteLine("\nArea of circle is " + a.compute(10, 0));
            Console.WriteLine("\n  ---------------------End of Program--------------------------");
            Console.ReadLine();
        }
    }
}
