using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"C:\Users\Merlan\Desktop\LABS\READ.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);

            String line = sr.ReadLine();

            String[] stringNumbers = line.Split(" ");

            int sum = 0;

            for (int i = 0; i < stringNumbers.Length; ++i)
            {
                int num = int.Parse(stringNumbers[i]);
                sum += num;
            }

            Console.WriteLine(sum);



            sr.Close();
            fileStream.Close();
        }
    }
}
