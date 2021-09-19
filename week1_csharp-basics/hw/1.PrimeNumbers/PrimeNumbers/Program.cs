using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            var n = Console.Read();
            var i = 3;
            Console.WriteLine(2);
            while (i <= n)
            {
                if (i%2 != 0 && i%3 != 0 && i%5 != 0) {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
