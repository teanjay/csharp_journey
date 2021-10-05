using System;

namespace IsItPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "ASDFGHJKLLKJHGFDSA";
            System.Text.StringBuilder reverse = new System.Text.StringBuilder(str);
            bool isPalindrom = false;
            int k = reverse.Length - 1;

            for (int j = 0; j < reverse.Length/2; j++)
            {
                if (reverse[j] == reverse[k - j])
                {
                    isPalindrom = true;
                    continue;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrom);
        }
    }
}
