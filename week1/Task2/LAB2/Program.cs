using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        public string name;
        public string id;
        public int year;

        public Student()
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
            f();
            InfoPrint();

        }
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            f();
            InfoPrint();

        }
        public void f()
        {
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void InfoPrint()
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
