using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = true;

            // Генерация случайных чисел (рандомная позиция курсора при запуске):
            Random rand = new Random();
            int x = rand.Next(Console.BufferWidth); // метод Next() возврю случ. число типа 'int'
            int y = rand.Next(Console.BufferHeight);
            Console.WriteLine($"X = {x}, Y = {y}");
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            Console.Write(symbol);
            //Console.WriteLine((char)2);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key.ToString());
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x -= 2; break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x += 2; break;
                    
                }
                if (y < 1) y = 1;
                if (x < 0) x = 0;
                if (y > Console.BufferHeight - 1) y = Console.BufferHeight - 1;
                if (x > Console.BufferWidth - 1) x = Console.BufferWidth - 1;

                Console.Clear();
                Console.WriteLine($"X = {x}, Y = {y}");
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);
        }
    }
}
