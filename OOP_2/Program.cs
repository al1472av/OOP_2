using System;

namespace OOP_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Точка A");
                var a = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Точка B");
                var b = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Точка C");
                var c = new Point(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
                var triangle = new Triangle(a, b, c);
                Console.WriteLine($"Площа {triangle.Area()}");
                Console.WriteLine($"Периметр {triangle.Perimeter()}");
                Console.WriteLine(triangle);
                Console.ReadLine();
            }
        }
    }
}