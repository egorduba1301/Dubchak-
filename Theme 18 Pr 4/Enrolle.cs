using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_4
{
    public class Enrolle : Person
    {
        //Инициализировал свойства
        public string Faculty
        {
            get { return Faculty; }
            set { Faculty = value; }
        }
        //Конструктор с параметрами
        public Enrolle(string Name, string Surname, DateTime datebirthday, string faculty)
            : base(Name, Surname, datebirthday)
        {
            Faculty = faculty;
        }
        //Метод для вычисления возраста

        public override int GetAge()
        {
            return (DateTime.Now - Datebirthday).Days / 365;
        }
        //Метод вывода
        public new void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Факультет: {Faculty}");
        }
    }

}
