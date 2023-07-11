using ShapesLibrary;

namespace ShapesTestProject
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void TestNegativeValues()
        {
            var rectangle = new Rectangle(-1, -2);
            Assert.IsTrue(rectangle.GetArea().Equals(0));

            var square = new Square(-3);
            Assert.IsTrue(square.GetArea().Equals(0));
        }

        [TestMethod]
        public void TestAreaRect()
        {
            int width = 12;
            int height = 5;
            double expected = 60;

            var rectangle = new Rectangle(width, height);
            double actual = rectangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaSquare()
        {
            int side = 5;
            double expected = 25;

            var square = new Square(side);
            double actual = square.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class EllipseTest
    {
        [TestMethod]
        public void TestNegativeValues()
        {
            var ellipse = new Ellipse(-4, -5);
            Assert.IsTrue(ellipse.GetArea().Equals(0));

            var circle = new Circle(-6);
            Assert.IsTrue(circle.GetArea().Equals(0));
        }

        [TestMethod]
        public void TestAreaCircle()
        {
            int rad = 5;
            double expected = 78.53981633974483;

            var circle = new Circle(rad);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaTriangle()
        {
            int a = 12;
            int b = 5;
            int c = 8;
            double expected = 14.523687548277813;

            var triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestNegativeValues()
        {
            var triangle = new Triangle(-7, -8, -9);
            Assert.IsTrue(triangle.GetArea().Equals(0));
        }

        [TestMethod]
        public void TestAreaTriangle()
        {
            int a = 12;
            int b = 5;
            int c = 8;
            double expected = 14.523687548277813;

            var triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnexistedTriangle()
        {
            int a = 12;
            int b = 5;
            int c = 3;
            double expected = 0;

            var triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAreaRightTriangle()
        {
            int a = 5;
            int b = 4;
            int c = 3;
            double expected = 6;

            var rightTriangle = new Triangle(a, b, c);
            double actual = rightTriangle.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}