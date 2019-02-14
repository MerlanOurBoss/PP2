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
            n = Convert.ToInt32(Console.ReadLine());// Мы добавляем число n это размер чисел.
            string[] numbers = Console.ReadLine().Split(' '); // Это массив строк, понадобится это в будущем, чтобы написать все элементы.
            List<int> prime = new List<int>(); // Я открыл лист чтобы записывать туда простые числа.
            for (int i = 0; i < n; i++)
            { // я открыл цикл,  чтобы пробежаться с нуля до n;
                int y = int.Parse(numbers[i]); // Я даю значение элемента у к числу п
                int x = 1; // Я даю значение целому числу x, когда числа простые x = 1
                for (int j = 2; j < y; j++)
                { // Я открыл цикл              
                    if (y % j == 0)
                    {
                        x = 0;
                    }
                }
                if (x == 1 && y > 1)
                    prime.Add(y);
            }
            Console.WriteLine(prime.Count);
            for (int i = 0; i < prime.Count; i++)
                Console.Write(prime[i] + " ");
            Console.ReadKey();
        }
    }
}