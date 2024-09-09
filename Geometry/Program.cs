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
            Console.Write("Количество столбцов? ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество строк? ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(delimiter1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);

            //Console.Write("Количество строк? ");
            //rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(delimiter1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
