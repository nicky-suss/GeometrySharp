namespace GeoSharp;

public static class PlaneGeometry
{
    public static class Square
    {
        public static double GetArea(double a) => a * a;
        public static double GetPerimeter(double a) => 4 * a;
    }
    public static class Rect
    {
        public static double GetArea(double a, double b) => a * b;
        public static double GetPerimeter(double a, double b)
        {
            double P = a + b;
            return P * 2;
        }
    }

    public static class Triangle
    {
        public static double GetArea(double b, double h)
        {
            double A = b * h;
            return A / 2;
        }
    }
    public static class Circle
    {
        public static double GetArea(double r)
        {
            double S = r * r;
            return S * Math.PI;
        }
        public static double GetLength(double r)
        {
            double L = r * Math.PI;
            return L * 2;
        }
    }
    public static class Trapezoid
    {
        public static double GetArea(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
        public static double GetPerimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }
    public static class Rhombus
    {
        public static double GetArea(double dOne, double dTwo)
        {
            return (dOne * dTwo) / 2;
        }
        public static double GetPerimeter(double a)
        {
            return 4 * a;
        }
    }
}