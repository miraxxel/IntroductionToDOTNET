using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimiter1 = "\n--------------------------------------------------------------------------------\n";
        static readonly string delimiter2 = "\n================================================================================\n";
        static void Main(string[] args)
        {
            Console.WriteLine("C# DataTypes");

            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(100));
            //Console.WriteLine(bool.Parse("False"));
            #endregion

            #region Char
            // Unicode
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(char.GetNumericValue(char.MaxValue));

            // ctrl(зажать)+k+c - закомментить блок кода, в регион поместить вместо c - s
            // ctrl(зажать)+m+m - свернуть блок кода 
            #endregion

            #region IntegralTypes
            //Console.Write($"Переменная типа 'short' занимает {sizeof(short)} Байта памяти, ");
            //Console.WriteLine($"и принимает значения в диапозоне: {short.MinValue} ... {short.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'ushort': {ushort.MinValue} ... {ushort.MaxValue}");

            //Console.WriteLine(delimiter1);

            //Console.Write($"Переменная типа 'Int16' занимает {sizeof(Int16)} Байта памяти, ");
            //Console.WriteLine($"и принимает значения в диапозоне: {Int16.MinValue} ... {Int16.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'UInt16': {UInt16.MinValue} ... {UInt16.MaxValue}");

            //Console.WriteLine(delimiter2);

            //Console.Write($"Переменная типа 'int' занимает {sizeof(int)} Байта памяти, ");
            //Console.WriteLine($"и принимает значения в диапозоне: {int.MinValue} ... {int.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'uint': {uint.MinValue} ... {uint.MaxValue}");

            //Console.WriteLine(delimiter1);

            //Console.Write($"Переменная типа 'Int32' занимает {sizeof(Int32)} Байта памяти, ");
            //Console.WriteLine($"и принимает значения в диапозоне: {Int32.MinValue} ... {Int32.MaxValue}");
            //Console.WriteLine($"Диапазон принимаемых значений 'UInt32': {UInt32.MinValue} ... {UInt32.MaxValue}");

            //Console.WriteLine(delimiter2); 
            #endregion

            // double a = 12.5896;
            // Console.WriteLine(a);

        }
    }
}
