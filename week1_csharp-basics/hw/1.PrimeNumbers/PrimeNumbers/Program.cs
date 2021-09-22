using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            var n = Console.Read();
            var i;
            if (n < 7) {
                if (n < 5) {
                    Console.WriteLine('error');
                    if (n < 3) {
                    Console.WriteLine('2');
                    if (n < 2)
                    {
                    Console.WriteLine('error');
                }}
                }
            }
            else {
                Console.WriteLine(2);
                Console.WriteLine(3);
                Console.WriteLine(5);
                Console.WriteLine(7);
                i = 7;
                 while (i <= n)
                 {
                     if (i%2!=0 && i%3!=0 && i%5!=0 && i%7!=0) {
                    Console.WriteLine(i);
                    }
                i++;
                }
            }
        }
    }
}
