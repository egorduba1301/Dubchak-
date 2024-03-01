using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Rectangle : Figure
    {


        private double _side1;
        private double _side2;

        public Rectangle(string name, double side1, double side2) : base(name)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double Side1 => _side1;
        public double Side2 => _side2;

        public override double Area()
        {
            return _side1 * _side2;
        }

        public override double Perimeter()
        {
            return 2 * (_side1 + _side2);
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Side 1: {_side1}, Side 2: {_side2}");
        }
    }

}
