using System;

namespace IsItPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
                string userInput = Console.ReadLine();
                if (!isPalindrome(userInput))
                {
                    Console.WriteLine("It's not palindrome");
                }
                else
                {
                    Console.WriteLine("Yes, it's palindrome");
                }
        }
        static bool isPalindrome(string a)
        {
            char[] inputArray = a.ToCharArray();
            char[] backwardsArray = a.ToCharArray();
            int l = backwardsArray.Length; // длина всей строки
            int m = l / 2; // середина строки
            for (int i = 0; i < m; i++)
            {
                var temp = backwardsArray[i];
                backwardsArray[i] = backwardsArray[l - i - 1];
                backwardsArray[l - i - 1] = temp;
            }

            for (int f = 0; f < l; f++)
            {
                if (inputArray[f] != backwardsArray[f])
                {
                    return false;

                }
            }
            return true;
        }
    }
}
