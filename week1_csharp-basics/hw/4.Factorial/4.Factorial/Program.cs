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
                if (!validateInput(userInput, out int a))
				{
					continue;
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
