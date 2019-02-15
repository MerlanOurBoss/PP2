using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task_4
{
    public class SimpleFileCopy
    {

        static void Main(string[] args)
        {
            string Filename = "info.txt";//көшетін файлды енгіземіз
            string sourcePath = @"C:\Users\Merlan\Desktop\LABS\path";//файлдың орналасқан жерін көрсетеміз
            string destPath = @"C:\Users\Merlan\Desktop\LABS\path 1";//файлдың баратын жерін көрсетеміз
                 // Path класын файлдарға,папкаларға баратын жолдарды басқару үшін қолданамыз

            string sourceFile = Path.Combine(sourcePath, Filename);//файлдың орналасқан жері
            string destFile = Path.Combine(destPath, Filename);//файлдың баратын жері

            File.Copy(sourceFile, destFile);//файлды көшіру операциясы және жолды көрсетеміз    
            Console.WriteLine("File copied");

            if (File.Exists(@"C:\Users\Merlan\Desktop\LABS\path\info.txt"))//Егер файл бастапқы жерінде болса
            {
                try
                {
                    File.Delete(@"C:\Users\Merlan\Desktop\LABS\path\info.txt");//оны кетіреді
                    Console.WriteLine("File deleated");
                }
                catch (IOException)//Егер болмаса ошибка шығарады
                {
                    Console.WriteLine("IOException");
                }
            }
        }
    }
}