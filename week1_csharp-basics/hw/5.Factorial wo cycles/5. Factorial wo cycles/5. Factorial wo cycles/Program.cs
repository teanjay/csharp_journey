using System;

namespace Factorial_wo_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (!validateInput(userInput, out int a))
                {
                    continue;
                }
                Console.WriteLine(factorial(a));
            }
        }
        static int factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * factorial(a - 1);
            }
        }
        static bool validateInput(string userInput, out int a)
        {
            if (!int.TryParse(userInput, out a))
            {
                Console.WriteLine("Invalid input");
                return false;
            }
            if (a < 1)
            {
                Console.WriteLine("Negative number");
                return false;
            }
            return true;
        }
    }
}