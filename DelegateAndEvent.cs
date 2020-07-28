using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practs
{
    public delegate void EventHandler();
    class eventdemo
    {
        public static event EventHandler display;
        static void Main()
        {
            Console.WriteLine("\n  ---------------------Program for delegates and events------------------------");
            display += new EventHandler(red);
            display += new EventHandler(blue);
            display += new EventHandler(green);
            display += new EventHandler(red);
            display.Invoke();
            Console.WriteLine("\n  ---------------------End of Program--------------------------");
            Console.ReadLine();
        }
        static void red()
        {
            Console.WriteLine("Rose is red");
        }
        static void blue()
        {
            Console.WriteLine("Sky is blue");
        }
        static void green()
        {
            Console.WriteLine("Grass is green");
        }

    }
}
