namespace GeometrySharp;

/// <summary>
/// 
/// </summary>
public static class AnalyticGeometry
{
    /// <summary>
    /// 
    /// </summary>
    public static class PointUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xOne"></param>
        /// <param name="yOne"></param>
        /// <param name="xTwo"></param>
        /// <param name="yTwo"></param>
        /// <returns></returns>
        public static double GetDistance(double xOne, double yOne, double xTwo, double yTwo)
        {
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
        /// <param name="xTwo"></param>
        /// <param name="yTwo"></param>
        /// <returns></returns>
        public static (double x, double y) GetMidpoint(double xOne, double yOne, double xTwo, double yTwo)
        {
            double midX = (xOne + xTwo) / 2;
            double midY = (yOne + yTwo) / 2;
            return (midX, midY);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class LineUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="xOne"></param>
        /// <param name="yOne"></param>
        /// <param name="xTwo"></param>
        /// <param name="yTwo"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        public static double GetSlope(double xOne, double yOne, double xTwo, double yTwo)
        {
            if (Math.Abs(xTwo - xOne) < 0.000001)
            {
                throw new DivideByZeroException("The slope is undefined for vertical lines because the change in X is zero.");
            }
            return (yTwo - yOne) / (xTwo - xOne);
        }
    }
}