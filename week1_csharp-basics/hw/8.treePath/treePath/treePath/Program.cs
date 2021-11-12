using System;
using System.IO;
namespace treePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"F:\Steam";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
    }
}
