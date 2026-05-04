namespace GeoSharp;

public static class SolidGeometry
{
    public static class Cube
    {
        public static double GetVolume(double a) => a * a * a;
        public static double GetSurfaceArea(double a) => (a * a) * 6;
    }
}