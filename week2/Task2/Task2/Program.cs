using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"C:\Users\Merlan\Desktop\LABS\READ.txt", FileMode.Open, FileAccess.Read); //файлды ашуға және оқуға мүмкіндік береді
            StreamReader sr = new StreamReader(fileStream); //файл ішіндегі мәліметті оқуға мүмкіндік береді

            FileStream fs = new FileStream(@"C:\Users\Merlan\Desktop\LABS\WRITE.txt", FileMode.Create, FileAccess.Write);//жаңа файлды ашуға және оқуға мүмкіндік аламыз
            StreamWriter sw = new StreamWriter(fs);//файлға жазуға мүмкіндік береді,шыққан нәтижені осы файлға жаза аламыз



            String line = sr.ReadLine(); // файлдағы сөзді баған(строка) түріне келтіреміз

            String[] stringNumbers = line.Split(" "); //бағанды массив түрінде бөліп жазамыз,алайда ' ' осындай белгі кездескен жағдайда ғана бөлеміз

            for (int i = 0; i < stringNumbers.Length; ++i)
            {
                int y = int.Parse(stringNumbers[i]); //Parse функциясы арқылы массивтағы әр бағанды сан реінде аламыз
                int x = 1;
                for (int j = 2; j < y; j++)//санды жай сан ба,емес па тексереміз
                {
                    if (y % j == 0)//жай сан тек өзіне және 1 бөліну керек,ол екіден бастап өзіне дейінгі басқа санға бөлінсе жай сен емес
                    {
                        x = 0;
                    }
                }
                if (x == 1 && y > 1)
                    sw.Write(y + " ");//жай сандарды жаңа файлға жазып сақтайды
                
            }

            sr.Close();
            fileStream.Close();
            sw.Close();
            fs.Close();//ағымдарға басқа операциялар орындалмас үшін жабамыз
        }
    }
}
