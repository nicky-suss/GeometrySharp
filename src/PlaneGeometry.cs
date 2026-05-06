namespace GeometrySharp;

/// <summary>
/// Provides static methods for calculating geometric properties of 2D shapes.
/// </summary>
public static class PlaneGeometry
{
    /// <summary>
    /// Provides calculations for square geometry.
    /// </summary>
    public static class Square
    {
        /// <summary>
        /// Calculates the area of a square.
        /// </summary>
        /// <param name="a">The length of a side.</param>
        /// <returns>The area of the square.</returns>
        public static double GetArea(double a) => a * a;
        /// <summary>
        /// Calculates the perimeter of a square.
        /// </summary>
        /// <param name="a">The length of a side.</param>
        /// <returns>The perimeter of the square.</returns>
        public static double GetPerimeter(double a) => 4 * a;
    }
    /// <summary>
    /// Provides calculations for rectangle geometry.
    /// </summary>
    public static class Rect
    {
        /// <summary>
        /// Calculates the area of a rectangle.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <returns>The area of the rectangle.</returns>
        public static double GetArea(double a, double b) => a * b;
        /// <summary>
        /// Calculates the perimeter of a rectangle.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <returns>The perimeter of the rectangle.</returns>
        public static double GetPerimeter(double a, double b)
        {
            double P = a + b;
            return P * 2;
        }
    }
    /// <summary>
    /// Provides calculations for triangle geometry.
    /// </summary>
    public static class Triangle
    {
        /// <summary>
        /// Calculates the area of a triangle using the base and height.
        /// </summary>
        /// <param name="b">The length of the base.</param>
        /// <param name="h">The height of the triangle.</param>
        /// <returns>The area of the triangle.</returns>
        public static double GetArea(double b, double h)
        {
            double A = b * h;
            return A / 2;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double GetHeronArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
    /// <summary>
    /// Provides calculations for circle geometry.
    /// </summary>
    public static class Circle
    {
        /// <summary>
        /// Calculates the area of a circle.
        /// </summary>
        /// <param name="r">The radius of the circle.</param>
        /// <returns>The area of the circle.</returns>
        public static double GetArea(double r)
        {
            double S = r * r;
            return S * Math.PI;
        }
        /// <summary>
        /// Calculates the circumference (length) of a circle.
        /// </summary>
        /// <param name="r">The radius of the circle.</param>
        /// <returns>The circumference of the circle.</returns>
        public static double GetLength(double r)
        {
            double L = r * Math.PI;
            return L * 2;
        }
    }
    /// <summary>
    /// Provides calculations for trapezoid geometry.
    /// </summary>
    public static class Trapezoid
    {
        /// <summary>
        /// Calculates the area of a trapezoid.
        /// </summary>
        /// <param name="a">The length of the first parallel side.</param>
        /// <param name="b">The length of the second parallel side.</param>
        /// <param name="h">The height of the trapezoid.</param>
        /// <returns>The area of the trapezoid.</returns>
        public static double GetArea(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
        /// <summary>
        /// Calculates the perimeter of a trapezoid.
        /// </summary>
        /// <param name="a">Side A.</param>
        /// <param name="b">Side B.</param>
        /// <param name="c">Side C.</param>
        /// <param name="d">Side D.</param>
        /// <returns>The sum of all four sides.</returns>
        public static double GetPerimeter(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
    }
    /// <summary>
    /// Provides calculations for rhombus geometry.
    /// </summary>
    public static class Rhombus
    {
        /// <summary>
        /// Calculates the area of a rhombus using its diagonals.
        /// </summary>
        /// <param name="dOne">The first diagonal.</param>
        /// <param name="dTwo">The second diagonal.</param>
        /// <returns>The area of the rhombus.</returns>
        public static double GetArea(double dOne, double dTwo)
        {
            return (dOne * dTwo) / 2;
        }
        /// <summary>
        /// Calculates the perimeter of a rhombus.
        /// </summary>
        /// <param name="a">The length of a side.</param>
        /// <returns>The perimeter of the rhombus.</returns>
        public static double GetPerimeter(double a)
        {
            return 4 * a;
        }
    }
    /// <summary>
    /// Provides calculations for parallelogram geometry.
    /// </summary>
    public static class Parallelogram
    {
        /// <summary>
        /// Calculates the area of a parallelogram.
        /// </summary>
        /// <param name="b">The length of the base.</param>
        /// <param name="h">The height.</param>
        /// <returns>The area of the parallelogram.</returns>
        public static double GetArea(double b, double h)
        {
            return b * h;
        }
        /// <summary>
        /// Calculates the perimeter of a parallelogram.
        /// </summary>
        /// <param name="a">The length of the side.</param>
        /// <param name="b">The length of the base.</param>
        /// <returns>The perimeter of the parallelogram.</returns>
        public static double GetPerimeter(double a, double b)
        {
            return (a + b) * 2;
        }
    }
    /// <summary>
    /// Provides calculations for ellipse geometry.
    /// </summary>
    public static class Ellipse
    {
        /// <summary>
        /// Calculates the area of an ellipse.
        /// </summary>
        /// <param name="a">The semi-major axis.</param>
        /// <param name="b">The semi-minor axis.</param>
        /// <returns>The area of the ellipse.</returns>
        public static double GetArea(double a, double b)
        {
            return Math.PI * a * b;
        }
    }
    /// <summary>
    /// Provides calculations for circular sector geometry.
    /// </summary>
    public static class CircleSector
    {
        /// <summary>
        /// Calculates the area of a circular sector.
        /// </summary>
        /// <param name="a">The angle of the sector in degrees.</param>
        /// <param name="r">The radius of the circle.</param>
        /// <returns>The area of the sector.</returns>
        public static double GetArea(double a, double r)
        {
            return (a / 360.0) * (Math.PI * (r * r));
        }
    }
}