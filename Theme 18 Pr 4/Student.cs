using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_4
{
    public class Student : Person
    {
        //Инициализировал свойства
        public string Faculty
        {
            get { return Faculty; }
            set { Faculty = value; }
        }

        public int Course
        {
            get { return Course; }
            set { Course = value; }
        }
        //Конструктор с параметрами
        public Student(string Name, string Surname, DateTime Datebirthday, string faculty, int course)
            : base(Name, Surname, Datebirthday)
        {
            Faculty = faculty;
            Course = course;
        }
        //Метод для вычисления возраста
        public override int GetAge()
        {
            return (DateTime.Now - Datebirthday).Days / 365;
        }
        //Метод вывода
        public void Print()
        {
            base.PrintInfo();
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Курс: {Course}");
        }
    }
}
