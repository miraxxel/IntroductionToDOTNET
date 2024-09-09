//#define OUT_TO_SCREEN
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OUT_TO_SCREEN
            // в c# всё является объектами
            // как таковой компиляции нет, здесь проект билдиться (собирается)

            Console.Title = "Introduction to .NET"; // заголовок консольного окна

            //Console.Write("Hello .NET"); // просто выводит строку на экран (можно исп. Escape-последовательности)
            Console.WriteLine("Hello .NET"); // вывод строки с переносом курсора на следующую

            Console.BackgroundColor = ConsoleColor.DarkGreen; // цвет фона
            Console.ForegroundColor = ConsoleColor.White; // цвет текста

            // начало координат левый верхний угол
            Console.CursorLeft = 24; // координата курсора по оси 'X'
            Console.CursorTop = 5;  // координата курсора по оси 'Y'
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("Вот так задаются координаты");

            Console.ResetColor();   // применяет цветовую схему по умолчанию

            // размеры окна
            //Console.WindowWidth = 64;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(64, 16);

            // #region позволяет свернуть часть кода
            #region CodeSnippet 
            // положение окна на экране
            //Console.WindowLeft = 10; 
            //Console.WindowTop = 10;
            //Console.SetWindowPosition(10, 10);
            #endregion

            // окно консоли отображает то, что находится в буфере консоли,
            // а буфер это пямать, в кот. консоль хранит вывод
            // задаем размер буфера консоли (не может быть меньше размеров окна):
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
#endif

            Console.Write("Введите Ваше имя: ");
            string first_name = Console.ReadLine(); // метод ReadLine() читает строку с клавиатуры, до нажатия 'enter' и возвр. прочит-ую строку
            //Console.WriteLine(first_name);

            Console.Write("ВВедите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine()); 

            // Класс 'Convert' - набор статических методов, для преобразорвания типов.
            // Исп-ся как правило, когда др. преобразования не работают.

            //Console.WriteLine(age);

            //      Операции над строками:
            Console.WriteLine(last_name + " " + first_name + " " + age + " years"); // конкатенация строк
            
            // Кроме конкатенации строк, C# поддерж. форматирование строк:
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

            // Интерполяция - изменение/искажение
            // Интерполяция строк (наиболее удобный вариант): 
            Console.WriteLine($"{last_name} {first_name} {age} years");
        }
    }
}
