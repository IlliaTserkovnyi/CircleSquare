using System;

namespace CircleSquare
{
    public static class DigitMaker
    {
        public static double GetValidValue()
        {
            int tries = 3;
            do
            {
                Console.Write("Input the number: \nx=");
                string input = Console.ReadLine();
                if (DigitValidationHelper.IsDigitIn(input))
                {
                    return Convert.ToDouble(DigitValidationHelper.IsSlashInside(input) ?
                        (MakeFractional(input)) : ReplaceDot(input));
                }
                else
                {
                    Console.WriteLine("(!) Please input only digits");
                    tries--;
                    Console.WriteLine("Tries left: {0}", tries);
                }
                Console.WriteLine("============= \n");
            } while (tries >= 1);

            return GetDoubleRandom();
        }

        private static string MakeFractional(string item)
        {
            var number = item.Split('/');
            double a = Convert.ToDouble(number[0]);
            double b = Convert.ToDouble(number[1]);
            return (a / b).ToString();
        }

        private static double ShowTwoDecimals(double item)
        {
            return Convert.ToDouble(item.ToString("f2"));
        }

        private static string ReplaceDot(string item)
        {
            return item.Replace('.', ',');
        }

        private static double GetDoubleRandom()
        {
            Random random = new Random();
            Console.WriteLine("Helping you with random input...");
            return random.NextDouble() * (5 - 0.5) + 0.5;
        }
    }
}
