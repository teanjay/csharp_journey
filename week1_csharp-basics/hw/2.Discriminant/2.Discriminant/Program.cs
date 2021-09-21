using System;

namespace _2.Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            // здесь комментарий для развлечения с мердж конфликтами
            string string1 = "asd";
            int a, b, c;
            bool test = false;
            int i = 1;
            while (i > 0)
            {
                while (test == false)
                {
                    Console.WriteLine("Enter a");
                    string1 = Console.ReadLine();
                    test = int.TryParse(string1, out a);
                    if (test == false)
                    {
                        Console.WriteLine("Please, enter a number");
                    }
                }
                Console.WriteLine("OK, a = " + string1);
                a = int.Parse(string1);
                test = false;
                while (test == false)
                {
                    Console.WriteLine("Enter b");
                    string1 = Console.ReadLine();
                    test = int.TryParse(string1, out b);
                    if (test == false)
                    {
                        Console.WriteLine("Please, enter a number");
                    }
                }
                Console.WriteLine("OK, b = " + string1);
                test = false;
                b = int.Parse(string1);
                while (test == false)
                {
                    Console.WriteLine("Enter c");
                    string1 = Console.ReadLine();
                    test = int.TryParse(string1, out c);
                    if (test == false)
                    {
                        Console.WriteLine("Please, enter a number");
                    }
                }
                
                Console.WriteLine("вот это прикол")
                Console.WriteLine("OK, c = " + string1);
                c = int.Parse(string1);
                var dis = Math.Pow(b, 2) - (4 * a * c);
                test = false;
                Console.Clear();
                Console.WriteLine("If a = " + a + ", b = " + b + " and c = " + c + "\nDiscriminant = " + dis);
                Console.WriteLine("Another one?");
            }
        }
    }
}
