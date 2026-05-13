namespace GeometrySharp;

/// <summary>
/// Provides static methods for calculating geometric properties of 3D solids.
/// </summary>
public static class SolidGeometry
{
    /// <summary>
    /// Provides calculations for cube geometry.
    /// </summary>
    public static class Cube
    {
        /// <summary>
        /// Calculates the volume of a cube.
        /// </summary>
        /// <param name="a">The side length.</param>
        /// <returns>The volume of the cube.</returns>
        public static double GetVolume(double a) => a * a * a;
        /// <summary>
        /// Calculates the total surface area of a cube.
        /// </summary>
        /// <param name="a">The side length.</param>
        /// <returns>The surface area of the cube.</returns>
        public static double GetSurfaceArea(double a) => (a * a) * 6;
    }
    /// <summary>
    /// Provides calculations for sphere geometry.
    /// </summary>
    public static class Sphere
    {
        /// <summary>
        /// Calculates the volume of a sphere.
        /// </summary>
        /// <param name="r">The radius of the sphere.</param>
        /// <returns>The volume of the sphere.</returns>
        public static double GetVolume(double r) => ((r * r * r) * Math.PI) * (4.0 / 3.0);
        /// <summary>
        /// Calculates the surface area of a sphere.
        /// </summary>
        /// <param name="r">The radius of the sphere.</param>
        /// <returns>The surface area of the sphere.</returns>
        public static double GetSurfaceArea(double r) => ((r * r) * Math.PI) * 4;
    }
    /// <summary>
    /// Provides calculations for cylinder geometry.
    /// </summary>
    public static class Cylinder
    {
        /// <summary>
        /// Calculates the volume of a cylinder.
        /// </summary>
        /// <param name="r">The radius of the base.</param>
        /// <param name="h">The height of the cylinder.</param>
        /// <returns>The volume of the cylinder.</returns>
        public static double GetVolume(double r, double h) => ((r * r) * Math.PI) * h;
        /// <summary>
        /// Calculates the total surface area of a cylinder.
        /// </summary>
        /// <param name="r">The radius of the base.</param>
        /// <param name="h">The height of the cylinder.</param>
        /// <returns>The total surface area.</returns>
        public static double GetSurfaceArea(double r, double h) => (2 * Math.PI * r * (r + h));
    }
    /// <summary>
    /// Provides calculations for cone geometry.
    /// </summary>
    public static class Cone
    {
        /// <summary>
        /// Calculates the volume of a cone.
        /// </summary>
        /// <param name="r">The radius of the base.</param>
        /// <param name="h">The height of the cone.</param>
        /// <returns>The volume of the cone.</returns>
        public static double GetVolume(double r, double h) => (r * r * h * Math.PI) / 3.0;
        /// <summary>
        /// Calculates the total surface area of a cone.
        /// </summary>
        /// <param name="r">The radius of the base.</param>
        /// <param name="h">The height of the cone.</param>
        /// <returns>The total surface area.</returns>
        public static double GetSurfaceArea(double r, double h) => (Math.PI * r * (r + Math.Sqrt(h * h + r * r)));
        /// <summary>
        /// Calculates the slant height of a cone using the radius and the vertical height.
        /// </summary>
        /// <param name="r">The radius of the base.</param>
        /// <param name="h">The vertical height of the cone.</param>
        /// <returns>The slant height of the cone.</returns>
        public static double GetSlantHeight(double r, double h) => Math.Sqrt((r * r) + (h * h));
    }
    /// <summary>
    /// Provides calculations for cuboid (rectangular prism) geometry.
    /// </summary>
    public static class Cuboid
    {
        /// <summary>
        /// Calculates the volume of a cuboid.
        /// </summary>
        /// <param name="a">Length.</param>
        /// <param name="b">Width.</param>
        /// <param name="c">Height.</param>
        /// <returns>The volume of the cuboid.</returns>s
        public static double GetVolume(double a, double b, double c) => a * b * c;
        /// <summary>
        /// Calculates the total surface area of a cuboid.
        /// </summary>
        /// <param name="a">Length.</param>
        /// <param name="b">Width.</param>
        /// <param name="c">Height.</param>
        /// <returns>The total surface area.</returns>
        public static double GetSurfaceArea(double a, double b, double c) => 2 * (a * b + b * c + a * c);
    }
    /// <summary>
    /// Provides calculations for square-based pyramid geometry.
    /// </summary>
    public static class Pyramid
    {
        /// <summary>
        /// Calculates the volume of a square-based pyramid.
        /// </summary>
        /// <param name="a">The side length of the base.</param>
        /// <param name="h">The height of the pyramid.</param>
        /// <returns>The volume of the pyramid.</returns>
        public static double GetVolume(double a, double h) => ((a * a) * h) / 3.0;
        /// <summary>
        /// Calculates the total surface area of a square-based pyramid.
        /// </summary>
        /// <param name="a">The side length of the base.</param>
        /// <param name="h">The height of the pyramid.</param>
        /// <returns>The total surface area.</returns>
        public static double GetSurfaceArea(double a, double h) => (a * a) + 2 * a * Math.Sqrt(((a * a) / 4) + h * h);
    }
}