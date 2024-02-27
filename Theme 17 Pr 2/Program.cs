using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme_17_Pr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Крижановская ", "Арина", 5000, 2));
            employees.Add(new Engineer("Цвигуненко ", "Юлия", 4000, 5, 4));
            foreach (var st in employees)
            { st.OutPut(); st.Doxod(); { Console.WriteLine(st.Doxod()); }; }

            Console.ReadKey();

        }
    }
}
