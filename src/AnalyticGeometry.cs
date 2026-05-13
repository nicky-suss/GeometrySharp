namespace GeometrySharp;

/// <summary>
/// Provides static methods for analytic geometry calculations.
/// </summary>
public static class AnalyticGeometry
{
    /// <summary>
    /// Provides utility methods for operations involving points.
    /// </summary>
    public static class PointUtils
    {
        /// <summary>
        /// Calculates the Euclidean distance between two points in a 2D plane.
        /// </summary>
        /// <param name="xOne">The X-coordinate of the first point.</param>
        /// <param name="yOne">The Y-coordinate of the first point.</param>
        /// <param name="xTwo">The X-coordinate of the second point.</param>
        /// <param name="yTwo">The Y-coordinate of the second point.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double GetDistance(double xOne, double yOne, double xTwo, double yTwo)
        {
            if (Math.Abs(xOne - xTwo) < Extra.Precision && Math.Abs(yOne - yTwo) < Extra.Precision)
                Extra.ThrowIdenticalPoints();
            double dx = xTwo - xOne;
            double dy = yTwo - yOne;
            double xy = (dx * dx) + (dy * dy);
            return Math.Sqrt(xy);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xOne"></param>
        /// <param name="yOne"></param>
        /// <param name="zOne"></param>
        /// <param name="xTwo"></param>
        /// <param name="yTwo"></param>
        /// <param name="zTwo"></param>
        /// <returns></returns>
        public static double GetDistance3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo)
        {
            double dx = xTwo - xOne;
            double dy = yTwo - yOne;
            double dz = zTwo - zOne;
            return Math.Sqrt((dx * dx) + (dy * dy) + (dz * dz));
        }
        /// <summary>
        /// Calculates the midpoint between two points in a 2D plane.
        /// </summary>
        /// <param name="xOne">The X-coordinate of the first point.</param>
        /// <param name="yOne">The Y-coordinate of the first point.</param>
        /// <param name="xTwo">The X-coordinate of the second point.</param>
        /// <param name="yTwo">The Y-coordinate of the second point.</param>
        /// <returns>A tuple containing the X and Y coordinates of the midpoint.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static (double x, double y) GetMidpoint(double xOne, double yOne, double xTwo, double yTwo)
        {
            if (Math.Abs(xOne - xTwo) < Extra.Precision && Math.Abs(yOne - yTwo) < Extra.Precision)
            {
                Extra.ThrowIdenticalPoints();
            }
            double midX = (xOne + xTwo) / 2;
            double midY = (yOne + yTwo) / 2;
            return (midX, midY);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xOne"></param>
        /// <param name="yOne"></param>
        /// <param name="zOne"></param>
        /// <param name="xTwo"></param>
        /// <param name="yTwo"></param>
        /// <param name="zTwo"></param>
        /// <returns></returns>
        public static (double x, double y, double z) GetMidPoint3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo)
        {
            double midX3D = (xOne + xTwo) / 2;
            double midY3D = (yOne + yTwo) / 2;
            double midZ3d = (zOne + zTwo) / 2;
            return (midX3D, midY3D, midZ3d);
        }
    }
    /// <summary>
    /// Provides utility methods for operations involving lines.
    /// </summary>
    public static class LineUtils
    {
        /// <summary>
        /// Calculates the slope of a line passing through two points.
        /// </summary>
        /// <param name="xOne">The X-coordinate of the first point.</param>
        /// <param name="yOne">The Y-coordinate of the first point.</param>
        /// <param name="xTwo">The X-coordinate of the second point.</param>
        /// <param name="yTwo">The Y-coordinate of the second point.</param>
        /// <returns>The slope of the line.</returns>
        /// <exception cref="DivideByZeroException">Thrown when the line is vertical and the change in X is zero.</exception>
        public static double GetSlope(double xOne, double yOne, double xTwo, double yTwo)
        {
            if (xOne == xTwo && yOne == yTwo)
            {
                Extra.ThrowIdenticalPoints();
            }
            if (Math.Abs(xTwo - xOne) < Extra.Precision)
            {
                Extra.ThrowDbz();
            }
            return (yTwo - yOne) / (xTwo - xOne);
        }
    }
}