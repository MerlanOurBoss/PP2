using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // Мы добавляем целое число n это размер массива.
            string[] numb = Console.ReadLine().Split(' ');
            // Это массив строк, он мне понадобится в будущем, чтобы записать все элементы массива.
            int[] array = new int[n];
            // Это массив целых чисел.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(numb[i]);
            }
            // Я открыл цикл , чтобы записать все элементы из массива.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " " + array[i] + " ");
            }
            // На этот раз я открыл цикл для записи дублирующих элементов массива.
            Console.ReadKey();
        }
    }
}