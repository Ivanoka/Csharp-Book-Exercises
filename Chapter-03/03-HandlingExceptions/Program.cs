namespace _03_HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            string? input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"Your are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The age you entered is not a valid number format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Console.WriteLine("After parsing");
            Console.WriteLine();


            Console.Write("Enter an amount: ");
            string? amount = Console.ReadLine();

            try
            {
                decimal amountValue = decimal.Parse(amount);
            }
            catch (FormatException) when (amount.Contains("$"))
            {
                Console.WriteLine("Amounts connot use the dollar sign!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Amounts must only contain digits!");
            }
        }
    }
}
