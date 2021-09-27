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
				if (!tryParseUserInput(userInput, out int n)) 
				{
					continue;
				}
				calcPrimeNumbers(n);
			}
		}
		static void calcPrimeNumbers(int n) //todo: change name & add method (?) to print
		{
			for (int i = 2; i <= n; i++)
			{
				if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0) 
				{
					if (i == 2 || i == 3 || i == 5 || i == 7) 
					{
						Console.WriteLine(i);
					}
					continue;
				}
				for (int k = 8; k <= i; k ++) 
				{
					if (i % k == 0) 
					{
						break;
					}
					if (k == i-1) 
					{
					    Console.WriteLine(i);
					}
				}
			}
	}
		static bool tryParseUserInput(string userInput, out int n) 
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
