using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_4
{
    public class Teacher : Person
    {
        //Инициализировал свойства
        public string Faculty { get { return Faculty; } set { Faculty = value; } }
        public string Position { get { return Position; } set { Position = value; } }
        public int Experience { get { return Experience; } set { Experience = value; } }

        public Teacher(string Name, string Surname, DateTime Datebirthday, string faculty, string position, int experience)
            : base(Name, Surname, Datebirthday)
        {
            Faculty = faculty;
            Position = position;
            Experience = experience;
        }
        //Метод для вычисления возраста
        public override int GetAge()
        {
            return (DateTime.Now - Datebirthday).Days / 365;
        }
        //Метод вывода
        public void ShowInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Должность: {Position}");
            Console.WriteLine($"Стаж: {Experience} лет");
        }
    }
}
