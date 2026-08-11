namespace _03_CastingConverting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a;
            Console.WriteLine(b);

            double c = 9.8;
            int d = (int)c;
            Console.WriteLine(d);
            Console.WriteLine();


            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e:N0} and f is {f:N0}");
            Console.WriteLine();


            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");

            double[] doubles = { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (var item in doubles)
            {
                Console.WriteLine($"ToInt32({item}) is {Convert.ToInt32(item)}");
            }

            foreach (var item in doubles)
            {
                Console.WriteLine(
                        format: "Math.Round({0}, 0, mode: MidpointRounding.AwayFromZero) is {1}",
                        arg0: item,
                        arg1: Math.Round(
                                value: item,
                                digits: 0,
                                mode: MidpointRounding.AwayFromZero
                            )
                    );
            }
            Console.WriteLine();


            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new();
            Console.WriteLine(me.ToString());
            Console.WriteLine();


            byte[] binaryObject = new byte[128];
            (new Random()).NextBytes(binaryObject);

            Console.WriteLine("Binary Object as bytes:");
            for (int i = 0; i < binaryObject.Length; i++)
            {
                Console.Write($"{binaryObject[i]:X} ");
            }
            Console.WriteLine();

            string encoded = Convert.ToBase64String(binaryObject);
            Console.WriteLine($"Binary Object as Base64: {encoded}");
            Console.WriteLine();


            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1920");

            Console.WriteLine($"I was bors {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");
            Console.WriteLine();


            Console.Write("How many eggs are there? ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }
        }
    }
}
