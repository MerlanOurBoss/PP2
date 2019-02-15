using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());// Мы добавляем целое число n это размер двумерного массива.
            string[,] array = new string[n, n]; // мы создаем двумерный массив 
            for (int i = 0; i <= n; i++) 
            {
                for (int j = 0; j <= i; j++) // Я создаю массив элементов, каждый номер столбца которого равен или меньше количества строк.
                {
                    array[i, j] = "[*]"; // Я равняю элементы массива [*]
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}