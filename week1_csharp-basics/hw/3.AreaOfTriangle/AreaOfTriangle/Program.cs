using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            while (true)
            {
                userInput = Console.ReadLine();
                string[] args1 = userInput.Split();
                if (args1.Length > 3 || args1.Length == 0)
                {
                    Console.WriteLine("Invalid number of arguments, try again");
                    continue;
                }
                if (!tryParseIntArray(args1, out var sides))
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }
                Console.WriteLine(calculateArea(sides, out var area));

            }
        }
        static double calculateArea(int[] sides, out double area)
        {
            area = 0;
            switch (sides.Length)
            {
                case 3:
                    int a = sides[0], b = sides[1], c = sides[2];
                    double p = (a + b + c)/2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return area;
                case 2:
                    a = sides[0];
                    b = sides[1];
                    area = (a * b) / 2;
                    return area;
                case 1:
                    a = sides[0];
                    area = ((Math.Pow(a, 2) * Math.Sqrt(3)) / 4);
                    return area;
                default:
                    break;
            }
            return area;
        }
        static bool tryParseIntArray(string[] args, out int[] sides)
        {
            sides = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                if (!int.TryParse(args[i], out sides[i]) || sides[i] <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
