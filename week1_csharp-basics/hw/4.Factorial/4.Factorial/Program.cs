using System;

namespace Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
                string userInput = Console.ReadLine();
                if (validateInput(userInput, out int a))
				{
                Console.WriteLine(factorial(a, out int result));
                }
        }
        public static int factorial(int a, out int result)
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
