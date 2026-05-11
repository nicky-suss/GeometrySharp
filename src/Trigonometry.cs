namespace GeometrySharp;

public static class Trigonometry
{
    public static class AngleConverter
    {
        public static double ToRadians(double degrees) => degrees * (Math.PI / 180);
        public static double ToDegrees(double radians) => radians * (180 / Math.PI);
    }
}