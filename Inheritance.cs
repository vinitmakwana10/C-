using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Room
    {
        public int length;
        public int breadth;
        public int area1;
        public Room(int x, int y)
        {
            length = x;
            breadth = y;
        }
        public void area()
        {
            area1 = (length * breadth);
        }
        public virtual void display()
        {
            Console.WriteLine("Area=" + area1);
        }
    }

    public class bedroom : Room
    {
        int height;
        public bedroom(int x, int y, int z) : base(x, y)
        {
            height = z;
        }
        public int volume()
        {
            return (length * breadth * height);
        }
        public override void display()
        {
            Console.WriteLine("Overridden display method");
        }
    }
    public class test
    {
        static void Main()
        {
            Console.WriteLine("\n  ---------------------Program for Inheritance--------------------------");
            bedroom b1 = new bedroom(14, 12, 10);
            b1.area();
            int volume = b1.volume();
            Console.WriteLine("Volume= " + volume);
            b1.display();
            Console.WriteLine("\n  ---------------------End of Program--------------------------");
            Console.ReadLine();
        }
    }
}
