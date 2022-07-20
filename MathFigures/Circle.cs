namespace MathFigures
{
    public class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Radius must have more 0");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}