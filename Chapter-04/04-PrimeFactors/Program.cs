using _04_PrimeFactorsLib;

namespace _04_PrimeFactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.Write("Enter natural number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    break;
                }
            }
            while (true);

            Console.WriteLine(CalcPrimeFactors.Calc(number));
        }
    }
}
