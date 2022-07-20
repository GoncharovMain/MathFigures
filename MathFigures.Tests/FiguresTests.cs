using MathFigures;
using Xunit;

namespace MathFigures.Tests
{
    public class FiguresTests
    {
        [Fact]
        public void DoubleCorrectFigures()
        {
            int numberDigitsRound = 5;

            double[] correctAreas = {
                10.82532,
                11.61895,
                6.00000,
                5026.54825,
                201.06193
            };

            IFigure[] figures = {
                new Triangle(5, 5, 5),
                new Triangle(8, 6, 4),
                new Triangle(3, 4, 5),

                new Circle(40),
                new Circle(8)
            };

            for (int i = 0; i < correctAreas.Length; i++)
            {
                Assert.Equal(correctAreas[i], Math.Round(figures[i].GetArea(), numberDigitsRound));
            }
        }

        [Fact]
        public void WrongFigures()
        {
            Assert.Throws<Exception>(new Action(() => new Triangle(-10, 15, 20)));
            Assert.Throws<Exception>(new Action(() => new Triangle(0, 100, -10)));

            Assert.Throws<Exception>(new Action(() => new Circle(-5)));
            Assert.Throws<Exception>(new Action(() => new Circle(0)));
        }

        [Fact]
        public void IsRightTriangle()
        {
            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle(3, 4, 5),
                new Triangle(4, 5, 3),
                new Triangle(5, 3, 4)
            };

            foreach (Triangle triangle in triangles)
            {
                Assert.True(triangle.IsRightTriangle());
            }
        }

        [Fact]
        public void IsNotRightTriangle()
        {
            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle(1, 4, 5),
                new Triangle(3, 5, 3),
                new Triangle(8, 6, 4)
            };

            foreach (Triangle triangle in triangles)
            {
                Assert.False(triangle.IsRightTriangle());
            }
        }

        [Fact]
        public void AreasSwapSidesTriangles()
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Triangle triangle2 = new Triangle(5, 3, 4);

            double area1 = triangle1.GetArea();
            double area2 = triangle2.GetArea();

            Assert.Equal(area1, area2);
        }
    }
}