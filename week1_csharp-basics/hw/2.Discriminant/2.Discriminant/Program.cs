using System;

namespace Discriminant_and_roots
{
    public class Program
    {
        static void Main(string[] args)
        {
            getRoots(Console.ReadLine());
        }

        public static bool validateUserInput(string userInput, ref int a, ref int b, ref int c)
        {
            var userInputArr = userInput.Split(); 
            return userInputArr.Length == 3 &&
                int.TryParse(userInputArr[0], out a) &&
                int.TryParse(userInputArr[1], out b) &&
                int.TryParse(userInputArr[2], out c);
        }
        public static string getRoots(string userInput)
        {
            int a = 0, b = 0, c = 0;
            double x1 = 0, x2 = 0;

            userInput = Console.ReadLine();
            if (!validateUserInput(userInput, ref a, ref b, ref c))
            {
                Console.WriteLine("Invalid input, try again");
                return "0";
            }
            if (a == 0)
            {

                x1 = -c / b;
                Console.WriteLine("x = " + x1);
                return x1.ToString();
            }
            var discriminant = Math.Pow(b, 2) - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Negative discriminant. No roots.");
                return "";
            }

            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            string answer = x1.ToString() + " " + x2.ToString();
            return answer;
        }
    }
}
