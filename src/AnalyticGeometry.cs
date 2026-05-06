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
        /// <param name="xTwo"></param>
        /// <param name="yOne"></param>
        /// <param name="yTwo"></param>
        /// <returns></returns>
        public static double GetDistance(double xOne, double xTwo, double yOne, double yTwo)
        {
            double dx = xTwo - xOne;
            double dy = yTwo - yOne;
            double xy = (dx * dx) + (dy * dy);
            return Math.Sqrt(xy);
        }
    }
}