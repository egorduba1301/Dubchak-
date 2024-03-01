using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_18_Pr_4
{
    public abstract class Person
    {
        //Инициализировал свойства
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public DateTime Datebirthday
        {
            get { return Datebirthday; }
            set { Datebirthday = value; }
        }
        
        public string Faculty
        {
            get { return Faculty; }
            set { Faculty = value; }
        }

        //Коснструктор с параметрами
        public Person(string name, string surname, DateTime datebirthday)
        {
            Name = name;
            Surname = surname;
            Datebirthday = datebirthday;
        }
        //Абстрактный метод
        public abstract int GetAge();
        //Метод вывода
        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname}, {GetAge()} лет");
        }
    }
}      
    

