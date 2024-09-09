//#define NUMERIC_TYPES
//#define LITERALS
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

#if NUMERIC_TYPES
//
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

            double a = 12.56;
            Console.WriteLine(a * 10000);

            // single precision
            Console.Write($"Переменная типа 'float' занимает {sizeof(float)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа 'Single' занимает {sizeof(Single)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {Single.MinValue} ... {Single.MaxValue}");

            Console.WriteLine(delimiter2);

            Console.Write($"Переменная типа 'double' занимает {sizeof(double)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа 'Double' занимает {sizeof(Double)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {Double.MinValue} ... {Double.MaxValue}");

            Console.WriteLine(delimiter2);

            // decimal
            Console.Write($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine(delimiter1);
            Console.Write($"Переменная типа 'Double' занимает {sizeof(Decimal)} Байта памяти, ");
            Console.WriteLine($"и принимает значения в диапозоне: {Decimal.MinValue} ... {Decimal.MaxValue}"); 
#endif

#if LITERALS
//
            Console.WriteLine(123.GetType()); // int
            Console.WriteLine(123u.GetType()); // uint
            Console.WriteLine(123l.GetType()); // long

            Console.WriteLine(delimiter1);

            Console.WriteLine(123.4.GetType()); // double
            Console.WriteLine(123.4f.GetType()); // float
            Console.WriteLine(123.4m.GetType()); // decimal

            Console.WriteLine(delimiter1);

            Console.WriteLine('+'.GetType());
            Console.WriteLine("Hello".GetType()); 
#endif
            #region Conversions1
            //Console.WriteLine(((byte)5).GetType().Name); // c-like notation

            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + "\t" + b);
            //a = (byte)b; // Truncation - усечение чисел, урезается либо дробная часть при записи дробного числа в целочисленную переменную, 
            //             // либо старшие байты целого числа при записи его в меньшую целочисленную переменную.
            //Console.WriteLine(a + "\t" + b);
            #endregion

            try
            {
                int a = int.MaxValue;
                uint b = int.MaxValue;
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType());
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Buy");
        }
    }
}
