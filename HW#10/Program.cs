using HW_10;
using System;
using System.Collections.Generic;

namespace HW_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>
            {   new Triangle(new Point(1, 2), new Point(1, 0), new Point(0, 0)),
                new Triangle(new Point(-1, -2), new Point(0, -1), new Point(1, 1)),
                new Triangle(new Point(0, 0), new Point(2, 2), new Point(4, 4))};

            foreach (var triangle in triangles) { triangle.Print(); }
            Console.ReadLine();
        }
    }
}