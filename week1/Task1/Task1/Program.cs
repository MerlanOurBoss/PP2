using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());// Мы n-ді енгіземіз бұл сандардың размері
            string[] numbers = Console.ReadLine().Split(' '); // бұл элемментерді жазуға керек массив
            List<int> prime = new List<int>(); // Листі аштым ішіне жай сандарды сақтау үшін
            for (int i = 0; i < n; i++)
            { 
                int y = int.Parse(numbers[i]);//Parse функциясы арқылы массивтағы әр бағанды сан реінде аламыз
                int x = 1; // Я даю значение целому числу x, когда числа простые x = 1
                for (int j = 2; j < y; j++)//санды жай сан ба,емес па тексереміз
                {    
                    if (y % j == 0)//жай сан тек өзіне және 1 бөліну керек,ол екіден бастап өзіне дейінгі басқа санға бөлінсе жай сен емес
                    {
                        x = 0;
                    }
                }
                if (x == 1 && y > 1)
                    prime.Add(y);//жай сандарды Листқа жазып сақтайды
            }
            Console.WriteLine(prime.Count);// Листін ішіндегі сандарды санайды
            for (int i = 0; i < prime.Count; i++)
                Console.Write(prime[i] + " "); // Листін ішіндегі сандарды жазады
            Console.ReadKey();
        }
    }
}