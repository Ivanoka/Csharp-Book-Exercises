namespace _03_BitwiseAndShiftOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 00001010
            int b = 6;  // 00000110
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a & b = {a & b}");
            Console.WriteLine($"a | b = {a | b}");
            Console.WriteLine($"a ^ b = {a ^ b}");
            Console.WriteLine($"a << 3 = {a << 3}");
            Console.WriteLine($"a * 8 = {a * 8}");
            Console.WriteLine($"b >> 1 = {b >> 1}");
            Console.WriteLine();

            Console.WriteLine("Outputting integers ad binary:");
            Console.WriteLine($"a =     {ToBinaryString(a)}");
            Console.WriteLine($"b =     {ToBinaryString(b)}");
            Console.WriteLine($"a & b = {ToBinaryString(a & b)}");
            Console.WriteLine($"a | b = {ToBinaryString(a | b)}");
            Console.WriteLine($"a ^ b = {ToBinaryString(a ^ b)}");
        }

        static string ToBinaryString(int value)
        {
            return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
        }
    }
}
