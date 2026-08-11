namespace _03_IterationStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.WriteLine();


            //string? password;

            //do
            //{
            //    Console.Write("Enter your password: ");
            //    password = Console.ReadLine();
            //}
            //while (password != "pa$$w0rd");

            //Console.WriteLine("Correct!");
            //Console.WriteLine();


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            string[] names = { "Adam", "Barry", "Charlie", };

            foreach (var name in names)
            {
                Console.WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
