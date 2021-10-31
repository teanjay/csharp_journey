using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            char[] reverseArray = new char[userInput.Length];
            for (int i = userInput.Length; i > 0;  i--)
            {
                reverseArray[userInput.Length-i] = userInput[i-1];
            }
            Console.WriteLine(reverseArray);
        }
    }
}
