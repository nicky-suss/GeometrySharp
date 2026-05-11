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
    }
}