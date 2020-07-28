using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practs
{
    class pattern
    {
        static void Main()
        {
            int num, code;
            Console.WriteLine("\n\n  ----------------Program to design patterns--------------------");
            Console.Write("\n\nEnter the lines to be printed: ");
            num = Convert.ToInt32(Console.ReadLine());
        sid: Console.WriteLine("Design codes: \n1-Triangle\n2-Diamond\n3-Rectangle");
            Console.WriteLine("Enter code of shape to be designed: ");
            code = Convert.ToInt32(Console.ReadLine());
            switch (code)
            {
                case 1:
                    Console.WriteLine("\n\n  ----------------Triangle Design--------------------");
                    for (int i = 0; i < num; i++)
                    {
                        for (int l = 0; l < num - i; l++)
                            Console.Write(" ");
                        for (int j = 0; j <= 2 * (i - i); j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("\n\n  ----------------Diamond Design--------------------");
                    for (int i = 0; i < num; i++)
                    {
                        for (int l = 0; l < num - i; l++)
                            Console.Write(" ");
                        for (int j = 0; j <= 2 * (i - i); j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = (num - 1) - 1; i >= 0; i--)
                    {
                        for (int l = 0; l < num - i; l++)
                            Console.Write(" ");
                        for (int j = 0; j <= 2 * (i - i); j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.WriteLine("\n\n  ----------------Rectangle Design--------------------");
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Invalid input!!\nPlease try again\n");
                    goto sid;
                    break;
            }
            Console.WriteLine("\n\n  ----------------------End of Program------------------------");
            Console.ReadLine();
        }
    }
}
