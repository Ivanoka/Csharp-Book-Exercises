using System.Reflection;

namespace Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSeparator();
            Console.WriteLine($"{"Type",-8} {"Byte(s) of memory", -31} {"Min"} {"Min", 30}");
            WriteSeparator();
            Console.WriteLine($"{"sbyte",-8} {sizeof(sbyte),-2} {sbyte.MinValue,32} {sbyte.MaxValue,30}");
            Console.WriteLine($"{"byte",-8} {sizeof(byte),-2} {byte.MinValue,32} {byte.MaxValue,30}");
            Console.WriteLine($"{"short",-8} {sizeof(short),-2} {short.MinValue,32} {short.MaxValue,30}");
            Console.WriteLine($"{"ushort",-8} {sizeof(ushort),-2} {ushort.MinValue,32} {ushort.MaxValue,30}");
            Console.WriteLine($"{"int",-8} {sizeof(int),-2} {int.MinValue,32} {int.MaxValue,30}");
            Console.WriteLine($"{"uint",-8} {sizeof(uint),-2} {uint.MinValue,32} {uint.MaxValue,30}");
            Console.WriteLine($"{"long",-8} {sizeof(long),-2} {long.MinValue,32} {long.MaxValue,30}");
            Console.WriteLine($"{"byte",-8} {sizeof(byte),-2} {ulong.MinValue,32} {ulong.MaxValue,30}");
            Console.WriteLine($"{"float",-8} {sizeof(float),-2} {float.MinValue,32} {float.MaxValue,30}");
            Console.WriteLine($"{"double",-8} {sizeof(double), -2} {double.MinValue,32} {double.MaxValue,30}");
            Console.WriteLine($"{"decimal",-8} {sizeof(decimal), -2} {decimal.MinValue, 32} {decimal.MaxValue, 30}");
        }

        static void WriteSeparator()
        {
            for (int i = 0; i < 74; i++) 
            { 
                Console.Write('-'); 
            }

            Console.WriteLine();
        }
    }
}
