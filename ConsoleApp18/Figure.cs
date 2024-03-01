using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    public abstract class Figure
    {


        private string _name;

        public Figure(string name)
        {
            _name = name;
        }

        public string Name => _name;

        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Print()
        {
            Console.WriteLine($"Figure: {_name}");
        }
    }
}
