#define ARRAYS_1
#define ARRAYS_2
#define JAGGED_ARRAYS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if ARRAYS_1

            //int[] arr = { 3, 5, 8, 13, 21 };
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            Console.Write("Введите кол-во эл-ов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            // Заполнение случайными числами
            Random rand = new Random(0);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(50, 100);
            }

            // Вывод Массива на экран
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            // r-b for
            /*foreach (int i in arr)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();*/


            // массив является объектом, обладает характеристиками, состояниями и поведениями
            Console.WriteLine($"Сумма эл-ов массива: {arr.Sum()}");
            Console.WriteLine($"Среднее-арифметическое: {arr.Average()}");
            Console.WriteLine($"Минимальное: {arr.Min()}");
            Console.WriteLine($"Максимальное: {arr.Max()}"); 

#endif

#if ARRAYS_2
            //int[,] i_arr_2 = new int[3, 4]; // размерность может указ-ся в ласт []
            int[,] i_arr_2 = new int[,]
                {
                    { 0, 1, 1, 2 },
                    { 3, 5, 8, 13 },
                    { 21, 34, 55, 89 },
                    { 144, 233, 377, 610 }
                };
            // Rank содержит кол-во измерений массива
            //Console.WriteLine((new int[5]).Rank);
            Console.WriteLine(i_arr_2.Rank);

            Console.WriteLine($"Кол-во измерений массива: {i_arr_2.Rank}");
            Console.WriteLine($"Кол-во эл-ов в нулевом измерении (кл-во строк): {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Кол-во эл-ов в первом измерении (кл-во столбцов): {i_arr_2.GetLength(1)}");

            for ( int i = 0; i < i_arr_2.GetLength(0); i++ ) 
            {
                for ( int j = 0; j < i_arr_2.GetLength(1); j++ )
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Cast<int> преобразует многомер. массив в одномер
            Console.WriteLine($"Сумма эл-ов: {i_arr_2.Cast<int>().Sum()}");
            Console.WriteLine($"Среднее-арифмет. эл-ов: {i_arr_2.Cast<int>().Average()}");
            Console.WriteLine($"Мин: {i_arr_2.Cast<int>().Min()}");
            Console.WriteLine($"Макс: {i_arr_2.Cast<int>().Max()}");


            /*foreach ( int i in i_arr_2) // не различ. строки
            {
                Console.WriteLine(i + "\t");
            }*/

#endif

#if JAGGED_ARRAYS
            int[][] j_arr = new int[][]
            {
                new int []{ 0, 1, 1, 2 },
                new int []{ 3, 5, 8, 13, 21 },
                new int []{ 34, 55, 89 },
                new int []{ 144, 233, 377, 610 },

            };
            for (int i = 0; i < j_arr.Length; i++) // как бы одномерный массив
            {
                for (int j = 0; j < j_arr[i].Length; j++) // и каждая строка тоже явл. одномер. массивом
                {
                    Console.Write(j_arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            //Console.WriteLine($"Сумма эл-ов: {j_arr.Sum()}");
            int sum = 0;
            int count = 0;
            int min, max;
            min = max = j_arr[0][0];
            for (int i = 0;i < j_arr.Length; i++)
            {
                sum += j_arr[i].Sum();
                count += j_arr[i].Length;
                if (j_arr[i].Min() < min) min = j_arr[i].Min();
                if (j_arr[i].Max() > max) max = j_arr[i].Max();
            }
            Console.WriteLine($"Сумма эл-ов: {sum}");
            Console.WriteLine($"Среднее-арифметич. эл-ов: {(double)sum/count}");
            Console.WriteLine($"Мин: {min}");
            Console.WriteLine($"Макс: {max}");
#endif


        }
    }
}
