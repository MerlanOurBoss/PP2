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

            FileStream fs = new FileStream(@"C:\Users\Merlan\Desktop\LABS\WRITE.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);


            String line = sr.ReadLine();

            String[] stringNumbers = line.Split(" ");

            for (int i = 0; i < stringNumbers.Length; ++i)
            {
                int y = int.Parse(stringNumbers[i]);
                int x = 1;
                for (int j = 2; j < y; j++)
                {
                    if (y % j == 0)
                    {
                        x = 0;
                    }
                }
                if (x == 1 && y > 1)
                    sw.Write(y + " ");
                
            }

            sr.Close();
            fileStream.Close();
            sw.Close();
            fs.Close();
        }
    }
}
