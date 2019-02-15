using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student // создаем класс Студент
    {
        public string name; // имя Студента
        public string id; // айди Студента
        public int year; // год Студента

        public Student() // конструктор без параметров
        {
            name = Console.ReadLine(); // введем имя
            id = Console.ReadLine(); // введем айди
            f();
            InfoPrint();

        }
        public Student(string name, string id) // конструктор с параметрами
        {
            this.name = name; // имя
            this.id = id; // айди
            f();
            InfoPrint();

        }
        public void f() // метод года
        {
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void InfoPrint() // метод введения данных 
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + id);
            Console.WriteLine("The year of the study: " + (year + 1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Merlan = new Student("Merlan", "18BD111148");
            Console.WriteLine();
            Student Meirambek = new Student("Meirambek", "18BD123456");
            Console.WriteLine();
            Student Maks = new Student();
            Console.ReadKey();
        }
    }
}
