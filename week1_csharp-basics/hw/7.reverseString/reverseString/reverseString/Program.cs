using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                char[] reversedArr = userInput.ToCharArray();
                Array.Reverse(reversedArr);
                Console.WriteLine(reversedArr);
            }
        }
    }
}
