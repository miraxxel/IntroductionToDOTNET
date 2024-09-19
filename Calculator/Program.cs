#define CALCULATOR_1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CALCULATOR_1
            try 
            {
                Console.Write("Введите выражение: ");
                string expression = Console.ReadLine();

                String[] tokens = expression.Split('+', '-', '*', '/', ' '); // сохр. в массив всё кроме указанного

                double a = Convert.ToDouble(tokens[0]);
                double b = Convert.ToDouble(tokens[1]);

                /*//   Метод Contains() класса 'string' определяет, содержит ли строка указанный символ или подстроку
                if (expression.Contains('+')) Console.WriteLine(a + b);
                else if (expression.Contains('-')) Console.WriteLine(a - b);
                else if (expression.Contains('*')) Console.WriteLine(a * b);
                else if (expression.Contains('/')) Console.WriteLine(a / b);
                else Console.WriteLine(("No operation")); 
                // переделать ^ через свитч кейс*/

                //  Метод IndexOfAny ищет первый индекс в строке expression, где встречается любой из символов, указанных в массиве char
                char operations = expression[expression.IndexOfAny(new char[] { '+', '-', '*', '/' })];
                switch (operations)
                {
                    case '+': Console.WriteLine($"{a} + {b} = {a + b}"); break;
                    case '-': Console.WriteLine($"{a} - {b} = {a - b}"); break;
                    case '*': Console.WriteLine($"{a} * {b} = {a * b}"); break;
                    case '/': Console.WriteLine($"{a} / {b} = {a / b}"); break;
                }
            }
            catch ( Exception ex )
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Вероятно, неправильный ввод, убедитесь, что ввод в формате: число оператор число");
            }
            
#endif


        }
    }
}
