namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Amir";
            Console.WriteLine($"{name} is {height} metres tall.");

            //int length1 = name.Length;
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters.");
            Console.WriteLine();


            dynamic something = "Ahmed";
            //something = 12;
            //something = new[] { 3, 5, 7 };
            Console.WriteLine($"Length is {something.Length}");
            Console.WriteLine();


            int number = 13;
            Console.WriteLine($"number has been set to: {number}");
            number = default;
            Console.WriteLine($"number has been reset to its default: {number}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
            Console.WriteLine();


            string[] names;
            names = new string[4];
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };
        }
    }
}
