//#define RHOMBUS1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static readonly string delimiter1 = "\n--------------------------------------------------------------------------------\n";
        static void Main(string[] args)
        {
            Console.Write("Введите размер: ");
            int size = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine(delimiter1);
            //0)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++) { Console.Write("*"); }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);
            //1)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++) { Console.Write("*"); }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);
            //2)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i; j++) { Console.Write("*"); }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);
            //3)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < i) Console.Write(" "); 
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);
            //4)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j < size - i - 1) Console.Write(" ");
                    else Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);
            //5)

#if RHOMBUS1
//
            /*for (int i = 0; i < size; i++) // верх
                {
                    for (int j = 0; j < size - i - 1; j++) { Console.Write(" "); }
                    Console.Write("/");
                    for (int j = 0; j < i * 2; j++) { Console.Write(" "); }
                    Console.Write("\\");
                    Console.WriteLine();
                }
                for (int i = size - 1; i >= 0; i--) // низ
                {
                    for(int j = 0; j < size - i - 1; j++) { Console.Write(" "); }
                    Console.Write("\\");
                    for (int j = 0; j < i * 2; j++) { Console.Write(" "); }
                    Console.Write("/");
                    Console.WriteLine();
                }*/

            for (int i = 0; i < size; i++) // верх
            {
                for (int j = i; j < size; j++) { Console.Write(" "); }
                Console.Write("/");
                for (int j = 0; j < i; j++) { Console.Write("  "); }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++) // низ
            {
                for (int j = 0; j <= i; j++) { Console.Write(" "); }
                Console.Write("\\");
                for (int j = i; j < size - 1; j++) { Console.Write("  "); }
                Console.Write("/");
                Console.WriteLine();
            } 
#endif
            //     size * 2 - т.к. верх и низ
            for (int i = 0; i < size * 2; i++)
            {
                for (int j = 0; j < size * 2; j++)
                {
                    if (i == j - size || j == i - size) Console.Write("\\");
                    else if (i == size - 1 - j || i - size == size * 2 - 1 - j) Console.Write("/");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }


            Console.WriteLine(delimiter1);
            //6)
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1) Console.Write(" +");
                    else Console.Write(" -");
                }
                Console.WriteLine();
            }

        }
    }
}
