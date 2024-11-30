using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 6; i++)
            {
                if (i % 3 == 0)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    if(i<3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        for(int j = 1;j<=3;j++)
                        {
                            Console.Write("  ");
                        }
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i=1;i<=7;i++)
            {
                if(i==1 || i==4)
                {
                    for(int j=1;j<=5;j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    Console.Write("* ");
                    for(int j=1;j<=3;j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int i=1;i<=7; i++)
            {
                if (i == 1 || i == 7)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else
                {
                    for(int j=1;j<=2;j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
