namespace GeometrySharp;

/// <summary>
/// Provides static methods for trigonometric calculations and coordinate conversions.
/// </summary>
public static class Trigonometry
{
    /// <summary>
    /// Provides methods for converting between different angle units.
    /// </summary>
    public static class AngleConverter
    {
        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        /// <param name="degrees">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
        public static double ToRadians(double degrees) => degrees * (Math.PI / 180.0);
        /// <summary>
        /// Converts an angle from radians to degrees.
        /// </summary>
        /// <param name="radians">The angle in radians.</param>
        /// <returns>The angle in degrees.</returns>
        public static double ToDegrees(double radians) => radians * (180.0 / Math.PI);
    }
    /// <summary>
    /// Provides methods for calculating relationships between sides and angles in a triangle.
    /// </summary>
    public static class TriangleRelations
    {
        /// <summary>
        /// Calculates the hypotenuse of a right-angled triangle using the Pythagorean theorem.
        /// </summary>
        /// <param name="a">The length of the first leg.</param>
        /// <param name="b">The length of the second leg.</param>
        /// <returns>The length of the hypotenuse.</returns>
        public static double GetHypotenuse(double a, double b)
        {
            if (a <= 0 || b <= 0)
                Extra.ThrowInvalidDimension();
            return double.Hypot(a, b);
        }
        /// <summary>
        /// Calculates the length of a missing leg in a right-angled triangle.
        /// </summary>
        /// <param name="hypot">The length of the hypotenuse.</param>
        /// <param name="knownLeg">The length of the known leg.</param>
        /// <returns>The length of the missing leg, or 0 if the hypotenuse is smaller than the leg.</returns>
        public static double GetLeg(double hypot, double knownLeg)
        {
            if (hypot < knownLeg)
                Extra.ThrowInvalidHypotenuse();
            return Math.Sqrt((hypot * hypot) - (knownLeg * knownLeg));
        }
        /// <summary>
        /// Calculates the third angle of a triangle given two other angles in degrees.
        /// </summary>
        /// <param name="angleA">The first angle in degrees.</param>
        /// <param name="angleB">The second angle in degrees.</param>
        /// <returns>The third angle in degrees.</returns>
        public static double GetThirdAngle(double angleA, double angleB)
        {
            if (angleA + angleB >= 180 || angleA < 0 || angleB < 0)
                Extra.ThrowInvalidAngles();
            return 180 - (angleA + angleB);
        }
        /// <summary>
        /// Calculates the area of a triangle using two sides and the included angle.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <param name="angle">The angle between the sides in degrees.</param>
        /// <returns>The area of the triangle.</returns>
        public static double GetAreaBySidesAndAngle(double a, double b, double angle)
        {
            if (angle <= 0 || angle >= 180)
                Extra.ThrowInvalidTriangleAngle();
            if (a <= 0 || b <= 0)
                Extra.ThrowInvalidDimension();
            return ((a * b) / 2) * Math.Sin(AngleConverter.ToRadians(angle));
        }
        /// <summary>
        /// Calculates the length of a side using the Law of Cosines.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <param name="angle">The angle between the two sides in degrees.</param>
        /// <returns>The length of the third side.</returns>
        public static double GetSideByCosineLaw(double a, double b, double angle)
        {
            if (angle <= 0 || angle >= 180)
                Extra.ThrowInvalidTriangleAngle();
            if (a <= 0 || b <= 0)
                Extra.ThrowInvalidDimension();
            double d = (a * a) + (b * b) - 2 * a * b * Math.Cos(AngleConverter.ToRadians(angle));
            if (d < 0)
                return 0;
            return Math.Sqrt(d);
        }
    }
}