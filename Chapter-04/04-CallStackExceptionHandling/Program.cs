using _04_CallStackExceptionHandlingLib;

namespace _04_CallStackExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main");
            Alpha();
        }

        static void Alpha()
        {
            Console.WriteLine("In Alpha");
            Beta();
        }
        static void Beta()
        {
            Console.WriteLine("In Beta");

            try
            {
                Calculator.Gamma();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught this: {ex.Message}");
                throw;
            }
        }
    }
}
