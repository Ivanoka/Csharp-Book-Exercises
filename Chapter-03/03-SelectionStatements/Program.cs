namespace _03_SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "ninsdsdgja";
            
            if (password.Length < 8)
            {
                Console.WriteLine("Your password is too short. Use at least 8 characters.");
            }
            else
            {
                Console.WriteLine("Your password is strong.");
            }
            Console.WriteLine();


            object o = 3;
            int j = 4;

            if (o is int i)
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply!");
            }
            Console.WriteLine();


            int number = (new Random().Next(1, 7));
            Console.WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    Console.WriteLine("Three or four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.WriteLine("After end of switch");
        A_label:
            Console.WriteLine("After A_label");
            Console.WriteLine();


            //string path = args.Length > 0 ? args[0] : string.Empty;

            //Console.WriteLine("Press R for read-only or W for writeable: ");
            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine();

            //Stream? s;

            //if (key.Key == ConsoleKey.R)
            //{
            //    s = File.Open(
            //            path,
            //            FileMode.OpenOrCreate,
            //            FileAccess.Read
            //        );
            //}
            //else
            //{
            //    s = File.Open(
            //            path,
            //            FileMode.OpenOrCreate,
            //            FileAccess.Write
            //        );
            //}

            //string message;

            //switch (s)
            //{
            //    case FileStream writeableFile when s.CanWrite:
            //        message = "The stream is a file that I can write to.";
            //        break;
            //    case FileStream readOnlyFile:
            //        message = "The stream is a read-only file.";
            //        break;
            //    case MemoryStream ms:
            //        message = "The stream is a memory address.";
            //        break;
            //    default:
            //        message = "The stream is some other type.";
            //        break;
            //    case null:
            //        message = "The stream is null.";
            //        break;
            //}

            //Console.WriteLine(message);
        }
    }
}
