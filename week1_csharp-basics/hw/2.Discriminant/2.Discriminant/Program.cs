using System;

namespace Discriminant_and_roots
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаём переменные
            string userinput;
            int a, b, c, result;
            double x1 = 0;
            double x2 = 0;

            while (true)
            {
                // Ввод переменных
                Console.WriteLine("\nEnter a");
                userinput = Console.ReadLine();
                a = int.Parse(userinput);
                Console.WriteLine("Enter b");
                userinput = Console.ReadLine();
                b = int.Parse(userinput);
                Console.WriteLine("Enter c");
                userinput = Console.ReadLine();
                c = int.Parse(userinput);

                //Вычисление дискриминанта
                var Discriminant = Math.Pow(b, 2) - (4 * a * c);

                //Вычисление корней дискриминанта. 
                if (Discriminant > 0) // При положительном дискриминанте находим два корня
                {
                    x1 = -b + Math.Sqrt(Discriminant);
                    x2 = -b - Math.Sqrt(Discriminant);
                    result = 1;
                }
                else if (Discriminant == 0) // При дискриминанте равном нулю у нас один корень
                {
                    x1 = -b / (2 * a);
                    result = 0;
                }
                else  // При отрицательном дискриминанте корней нет.
                {
                    result = -1;
                }

                //Вывод дискриминанта и корней уравнения.

                if (result == 1)
                {
                    Console.WriteLine("D = " + Discriminant + "\nx1 = " + x1 + "\nx2 = " + x2);
                }
                else if (result == 0)
                {
                    Console.WriteLine("D = " + Discriminant + "\nx = " + x1);
                }
                else if (result == -1)
                {
                    Console.WriteLine("D = " + Discriminant + "\nNo roots.");
                }
            }
        }
    }
}
