using System;

namespace HW_10
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public Point Vertex1 { get { return vertex1; } }
        public Point Vertex2 { get { return vertex2; } }
        public Point Vertex3 { get { return vertex3; } }

        public double Side1 { get { return vertex1.Distance(vertex2); } }
        public double Side2 { get { return vertex2.Distance(vertex3); } }
        public double Side3 { get { return vertex3.Distance(vertex1); } }

        public double Perimeter() => Side1 + Side2 + Side3;
        public double Square()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertices:");
            Console.WriteLine($"Vertex 1: {vertex1}");
            Console.WriteLine($"Vertex 2: {vertex2}");
            Console.WriteLine($"Vertex 3: {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Area:{Square()}");
            double distance1_2 = Side1;
            double distance2_3 = Side2;
            double distance3_1 = Side3;

            Console.WriteLine($"Distance between Vertex 1 and Vertex 2: {distance1_2}");
            Console.WriteLine($"Distance between Vertex 2 and Vertex 3: {distance2_3}");
            Console.WriteLine($"Distance between Vertex 3 and Vertex 1: {distance3_1}");
        }
    }
}
