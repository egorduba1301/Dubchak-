using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {



            {
                Figure[] figures = new Figure[]
                {
            new Rectangle("Rectangle", 5, 3),
            new Square(4),
            new Triangle("Triangle", 6, 4),
            new Circle("Circle", 2)
                };

                foreach (var figure in figures)
                {
                    figure.Print();
                    Console.WriteLine($"Area: {figure.Area()}, Perimeter: {figure.Perimeter()}");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
        }
    }
}
