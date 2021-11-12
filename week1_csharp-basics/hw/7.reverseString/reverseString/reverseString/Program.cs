using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            HandmadeReverse(userInput);
            StringBuilderReverse(userInput);
        }
        static void HandmadeReverse(string a)
        {
            char[] reverseArray = new char[a.Length];
            for (int i = a.Length; i > 0; i--)
            {
                reverseArray[a.Length - i] = a[i - 1];
            }
            Console.WriteLine(reverseArray);
        }
        static void StringBuilderReverse(string a)
        {

        }
    }
}
