using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        public static void probel(int a)//папкалардың саны артқан сайын біз пробел қойып отыратын функция құрамыз
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write("   ");
            }
        }
        public static void dir(DirectoryInfo dirs, int a)//папкадағы мәлімет туралы білу үшін функция құрамыз
        {
            foreach (FileInfo fi in dirs.GetFiles())//әр папка үшін файлдарды шығару
            {
                probel(a);//папкадағы файлдарды пробел қойып жазамыз
                Console.WriteLine(fi.Name);//файл аттарын шығарамыз
            }
            foreach (DirectoryInfo di in dirs.GetDirectories())//әр папка үшін ішіндегі папканы шығару,мәлімет алу
            {
                probel(a);
                Console.WriteLine(di.Name);//папканын атың шығарамыз
                dir(di, a + 1);//папканың ішінен папка немесе файл шыға бергенше функцияны қайта шақыра береміз және пробел қоямыз
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Merlan\Desktop\LABS\LABS\week1");//папка немесе файлға операциялар орындау үшін керек 
            dir(di, 0);//функцияны бірінші 0 беріп шақырамыз
        }
    }
}