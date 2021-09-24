using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            int a = 0, b = 0, c = 0, triangleType = 0;
            while (true)
            {
                userInput = Console.ReadLine();
                calculateTriangleType(userInput);
                Console.WriteLine(calculateArea(triangleType, a, b, c));

            }
        }
        static double calculateArea(int triangleType, int a, int b, int c)
        {
            switch (triangleType)
            {
                case 3:
                    double p = (a + b + c)/2;
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return area;
                case 2:
                    area = (a * b) / 2;
                    return area;
                case 1:
                    area = ((Math.Pow(a, 2) * Math.Sqrt(3)) / 4);
                    return area;
                default:
                    break;
            }
            return 0;
        }
        static int calculateTriangleType(string userInput, out int a, out int b, out int c)
        {
            int a = 0, b = 0, c = 0;
            var userInputArr = userInput.Split();
            var triangleType = userInputArr.Length;
            switch (triangleType)
            {
                case 3:
                    int.TryParse(userInputArr[0], out a);
                    int.TryParse(userInputArr[1], out b);
                    int.TryParse(userInputArr[2], out c);
                    break;
                case 2:
                    int.TryParse(userInputArr[0], out a);
                    int.TryParse(userInputArr[1], out b);
                    break;
                case 1:
                    int.TryParse(userInputArr[0], out a);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    break;
            }
            ;
        }
    }
}
