namespace _03_CheckingForOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.MaxValue - 1;
                Console.WriteLine($"Initial value: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The code overfloved but I caught the exception.");
            }
            Console.WriteLine();


            unchecked
            {
                int y = int.MaxValue + 1;
                Console.WriteLine($"Initial value: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
                y--;
                Console.WriteLine($"After decrementing: {y}");
            }
        }
    }
}
