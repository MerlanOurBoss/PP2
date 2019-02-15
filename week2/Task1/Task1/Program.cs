using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {   
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Merlan\Desktop\LABS\READ.txt", FileMode.Open, FileAccess.Read); //FileStream аркылы папканы окуга және жазуға  мүмкіндік аламыз
            StreamReader sr = new StreamReader(fs);// StreamReader ол ақпаратты санайтын ағын
                        
            string t;
            t = sr.ReadToEnd(); // файлдағы элемментерді t-ға береміз

            char[] arr = t.ToCharArray(); // стирнг t чарга болеміз
            Array.Reverse(arr); // оны кері айналдырам

            string m = new string(arr); // сол айналдырғанды m-ға салам

            if ( t == m) // тексерем Полиндром екендігін
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