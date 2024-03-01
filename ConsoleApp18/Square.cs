using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Square : Rectangle
    {


        public Square(double side) : base("Square", side, side)
        {
        }
    }

    class Triangle : Figure
    {
        private double _base;
        private double _height;

        public Triangle(string name, double @base, double height) : base(name)
        {
            _base = @base;
            _height = height;
        }

        public override double Area()
        {
            return 0.5 * _base * _height;
        }

        public override double Perimeter()
        {

            return 3 * _base;
        }
    }

    class Circle : Figure
    {
        private double _radius;

        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return 3.14 * _radius * _radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * _radius;
        }
    }
}
