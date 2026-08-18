namespace _04_PrimeFactorsLib
{
    public class CalcPrimeFactors
    {
        public static string Calc(int number)
        {
            string result = string.Empty;

            for (int divisor = 2; divisor <= number; divisor++)
            {
                while (number % divisor == 0)
                {
                    if (result == string.Empty)
                    {
                        result += divisor.ToString();
                    }
                    else
                    {
                        result += $" * {divisor}";
                    }

                    number /= divisor;
                }
            }

            return result;
        }
    }
}
