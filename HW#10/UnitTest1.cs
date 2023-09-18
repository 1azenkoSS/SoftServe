using System.Drawing;

namespace HW_10
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void Point_Returns_ToString_Correctly()
        {
            Point point = new Point(1, 2);
            string result = point.ToString();
            Assert.AreEqual("(1,2)", result);
        }
        [TestMethod]
        public void Correct_Distance()
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(0, 0);
            double expectedDistance = 2.23606797749979;
            double distance = point1.Distance(point2);
            Assert.AreEqual(expectedDistance, distance, 0.001);
        }
    }
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Correct_Sum_Of_Perimetr()
        {
            Point vertex1 = new Point(1, 2);
            Point vertex2 = new Point(1, 0);
            Point vertex3 = new Point(0, 0);
            Triangle triangle = new Triangle(vertex1, vertex2, vertex3);
            double expectedPerimeter = 5.23606797749979;
            double perimeter = triangle.Perimeter();
            Assert.AreEqual(expectedPerimeter, perimeter, 0.001);
        }
        [TestMethod]
        public void Correct_Square()
        {
            Point vertex1 = new Point(-1, -2);
            Point vertex2 = new Point(0, -1);
            Point vertex3 = new Point(1, 1);
            Triangle triangle = new Triangle(vertex1, vertex2, vertex3);
            double expectedSquare = 0.499999999999998;
            double square = triangle.Square();
            Assert.AreEqual(expectedSquare, square, 0.001);
        }

    }
}