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
                validateString(userInput);
                Console.WriteLine(calculateArea(triangleType, a, b, c));

            }
        }
        static double calculateArea(int sidesCount, int a, int b, int c)
        {
            switch (sidesCount)
            {
                case 3:
                    a = triangleSidesArray[0];
                    b = triangleSidesArray[1];
                    c = triangleSidesArray[2];
                    double p = (a + b + c)/2;
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return area;
                case 2:
                    a = triangleSidesArray[0];
                    b = triangleSidesArray[1];
                    area = (a * b) / 2;
                    return area;
                case 1:
                    a = triangleSidesArray[0];
                    area = ((Math.Pow(a, 2) * Math.Sqrt(3)) / 4);
                    return area;
                default:
                    break;
            }
            return 0;
        }
        static int validateString(string userInput, out int sidesCount, out int triangleSidesArray)
        {
            var userInputArr = userInput.Split();
            int triangleSide;
            int triangleSidesArray = new int[userInputArr.Length];
            if (userInputArr.Length > 2)
            {
                Console.WriteLine("Invalid input, try again");
            }
            else
            {
                for (int i = 0; i < userInputArr.Length; i++)
                {
                    if (int.TryParse(userInputArr[i], out triangleSide))
                    {
                        triangleSidesArray[i] = triangleSide;
                    }

                }
                sidesCount = triangleSidesArray.Length;
                if (sidesCount != userInputArr.Length)
                {
                    Console.WriteLine("Invalid input, try again");
                }
                else
                {
                    return sidesCount;
                }
                /*
                switch (triangleType)
                {
                    case 3:
                        int.TryParse(userInputArr[0], out );
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
                */
            }
        }
    }
}
