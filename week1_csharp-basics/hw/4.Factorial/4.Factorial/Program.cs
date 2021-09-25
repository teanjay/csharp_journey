using System;

namespace _4.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out int a))
                {
                    Console.WriteLine("Invalid input");
                    if (a < 1)
                    {
                        Console.WriteLine("Negative number");
                    }
                }
                Console.WriteLine(factorial(a, out int result));
            }
        }
        static int factorial(int a, out int result)
        {
            int i = 2;
            result = 1;
            while (i <= a)
            {
                result = result * i;
                i++;
            }

            return result;
        }
    }
}
