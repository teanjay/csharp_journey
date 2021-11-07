using System;
using System.Collections;

namespace PrimeNumbers 
{
	public class Program 
	{
		static void Main(string[] args) 
		{
			primeList(100);
		}
		public static ArrayList primeList(int a)
        {
		ArrayList primeNumbersList = new ArrayList();
			primeNumbersList.Add(2);
			for (int i = 3; i < a; i++)
			{
				bool isPrime = true;
				for (int j = 2; j < i; j++)
				{
					if (i % j == 0)
					{
						isPrime = false;
						break;
					}
				}
				if (isPrime == true)
				{
					primeNumbersList.Add(i);
				}

			}
			return primeNumbersList;
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
