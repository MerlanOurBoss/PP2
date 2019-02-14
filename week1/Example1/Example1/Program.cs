
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Merlan\Desktop\LABS\READ.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
                        
            string t;
            t = sr.ReadToEnd();

            char[] arr = t.ToCharArray();
            Array.Reverse(arr);

            string m = new string(arr);

            if ( t == m)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



            

        }
    }
}