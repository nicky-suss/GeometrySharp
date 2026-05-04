namespace GeoSharp;

public static class SolidGeometry
{
    public static class Cube
    {
        public static double GetVolume(double a) => a * a * a;
        public static double GetSurfaceArea(double a) => (a * a) * 6;
    }
    public static class Sphere
    {
        public static double GetVolume(double r) => ((r * r * r) * Math.PI) * (4.0 / 3.0);
        public static double GetSurfaceArea(double r) => ((r * r) * Math.PI) * 4;
    }
    public static class Cylinder
    {
        public static double GetVolume(double r, double h) => ((r * r) * Math.PI) * h;
        public static double GetSurfaceArea(double r, double h) => (2 * Math.PI * r * (r + h));
    }
    public static class Cone
    {
        public static double GetVolume(double r, double h) => (r * r * h * Math.PI) / 3.0;
        public static double GetSurfaceArea(double r, double h) => (Math.PI * r * (r + Math.Sqrt(h * h + r * r)));
    }
}