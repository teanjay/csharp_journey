using System;

namespace PrimeNumbers 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			while (true) 
			{
				var userInput = Console.ReadLine();
				if (!validateUserInput(userInput, out int n)) 
				{
					continue;
				}
				calcPrimeNumbers(n);
			}
		}
		static bool calcPrimeNumbers(int n) 
		{
			int i = 1;
			while (i <= n) 
			{
				if (i == 2 || i == 3 || i == 5 || i == 7) 
				{
					Console.WriteLine(i);
				}
				if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0) 
				{
					Console.WriteLine(i);
				}
				i++;
			}
			return true;
		}
		static bool validateUserInput(string userInput, out int n) 
		{

			if (!int.TryParse(userInput, out n)) 
			{
				Console.WriteLine("Invalid unput");
				return false;
			}
			if (n <= 1) {
				Console.WriteLine("number is too small");
				return false;
			}
			return true;
		}

	}
}
