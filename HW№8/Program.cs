namespace HW_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter shape type (circle or square) for shape {i + 1}: ");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "circle")
                {
                    Circle circle = new("", 0);
                    circle.Input();
                    shapes.Add(circle);
                }
                else if (choice.ToLower() == "square")
                {
                    Square square = new Square("", 0);
                    square.Input();
                    shapes.Add(square);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }

            Console.WriteLine("Shape information:");
            foreach (Shape shape in shapes)
            {
                shape.Output();
            }

            double maxPerimeter = -1;
            Shape shapeWithMaxPerimeter = null;

            foreach (Shape shape in shapes)
            {
                double perimeter = shape.Perimeter();
                if (perimeter > maxPerimeter)
                {
                    maxPerimeter = perimeter;
                    shapeWithMaxPerimeter = shape;
                }
            }

            Console.WriteLine($"Shape with maximum perimeter:");
            shapeWithMaxPerimeter.Output();

            shapes.Sort();
            Console.WriteLine("Shapes sorted by area:");
            foreach (Shape shape in shapes)
            {
                shape.Output();
            }
        }
    }
}