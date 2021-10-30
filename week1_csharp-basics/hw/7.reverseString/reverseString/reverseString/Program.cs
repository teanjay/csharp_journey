using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            char[] inputArray = userInput.ToCharArray();
            int l = inputArray.Length; // длина всей строки
            int m = l / 2; // середина строки
            for (int i = 0; i < m; i++)
            {
                var temp = inputArray[i];
                inputArray[i] = inputArray[l - i - 1];
                inputArray[l - i - 1] = temp;
            }
            Console.WriteLine(inputArray);
        }
    }
}
