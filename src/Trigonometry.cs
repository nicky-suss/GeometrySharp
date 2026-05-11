namespace GeometrySharp;

public static class Trigonometry
{
    public static class AngleConverter
    {
        public static double ToRadians(double degrees) => degrees * (Math.PI / 180);
        public static double ToDegrees(double radians) => radians * (180 / Math.PI);
    }
    public static class TriangleRelations
    {
        public static double GetHypotenuse(double a, double b) => double.Hypot(a, b);
        public static double GetLeg(double hypot, double knownLeg)
        {
            if (hypot < knownLeg)
                return 0;
            return Math.Sqrt((hypot * hypot) - (knownLeg * knownLeg));
        }
        public static double GetThirdAngle(double angleA, double angleB) => 180 - (angleA + angleB);
        public static double GetAreaBySidesAndAngle(double a, double b, double angle) => ((a * b) / 2) * Math.Sin(AngleConverter.ToRadians(angle));
        public static double GetSideByCosineLaw(double a, double b, double angle) => Math.Sqrt((a * a) + (b * b) - 2 * a * b * Math.Cos(AngleConverter.ToRadians(angle)));
    }
}