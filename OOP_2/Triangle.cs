using System;

namespace OOP_2
{
    public class Triangle
    {
        public Point VertexA { get; }
        public Point VertexB { get; }
        public Point VertexC { get; }
        public float EdgeA { get; }
        public float EdgeB { get; }
        public float EdgeC { get; }

        public Triangle(Point a, Point b, Point c)
        {
            VertexA = a;
            VertexB = b;
            VertexC = c;
            EdgeA = Point.Distance(a, b);
            EdgeB = Point.Distance(b, c);
            EdgeC = Point.Distance(c, a);

            if (EdgeA + EdgeB <= EdgeC && EdgeA + EdgeC <= EdgeB && EdgeC + EdgeB <= EdgeA)
                throw new Exception("Triangle does not exist");
        }

        public float Area()
        {
            var halfPerimeter = Perimeter() / 2;
            return (float)Math.Sqrt(halfPerimeter * (halfPerimeter - EdgeA) * (halfPerimeter - EdgeB) * (halfPerimeter - EdgeC));
        }

        public float Perimeter() => EdgeA + EdgeB + EdgeC;

        public override string ToString() => $"Точка А: {VertexA}; Точка B: {VertexB}; Точка C: {VertexC}\nРебро А: {EdgeA}; Ребро B: {EdgeB}; Ребро С: {EdgeC}";
        
    }
}