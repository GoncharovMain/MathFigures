namespace MathFigures
{
    /// <summary>
    /// side a opposite angle alpha
    /// side b opposite angle beta
    /// side c opposite angle gamma
    /// </summary>
    public class Triangle : IFigure
    {
        private double _a, _b, _c;

        private double _alpha, _beta, _gamma;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("One of side equal or less 0");

            _a = a;
            _b = b;
            _c = c;

            _alpha = GetAngleOpposite(_b, _c, _a);
            _beta = GetAngleOpposite(_a, _c, _b);
            _gamma = GetAngleOpposite(_a, _b, _c);
        }

        public double GetArea()
        {
            double p = (_a + _b + _c) / 2.0;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightTriangle() => _alpha == 90 || _beta == 90 || _gamma == 90;

        private double GetAngleOpposite(double a, double b, double c)
        {
            double arccos = Math.Acos((a * a + b * b - c * c) / (2.0 * a * b));

            return ConvertToDegree(arccos);
        }

        private double ConvertToDegree(double radian) => radian * 180.0 / Math.PI;
    }
}