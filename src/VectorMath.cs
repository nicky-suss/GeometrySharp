namespace GeometrySharp;

/// <summary>
/// Provides static methods for vector mathematics in 2D and 3D spaces.
/// </summary>
public static class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two 2D vectors.
    /// </summary>
    /// <param name="xOne">The X-component of the first vector.</param>
    /// <param name="yOne">The Y-component of the first vector.</param>
    /// <param name="xTwo">The X-component of the second vector.</param>
    /// <param name="yTwo">The Y-component of the second vector.</param>
    /// <returns>The scalar dot product of the two 2D vectors.</returns>
    public static double GetDotProduct(double xOne, double yOne, double xTwo, double yTwo) => (xOne * xTwo) + (yOne * yTwo);
    /// <summary>
    /// Calculates the dot product of two 3D vectors.
    /// </summary>
    /// <param name="xOne">The X-component of the first vector.</param>
    /// <param name="yOne">The Y-component of the first vector.</param>
    /// <param name="zOne">The Z-component of the first vector.</param>
    /// <param name="xTwo">The X-component of the second vector.</param>
    /// <param name="yTwo">The Y-component of the second vector.</param>
    /// <param name="zTwo">The Z-component of the second vector.</param>
    /// <returns>The scalar dot product of the two 3D vectors.</returns>
    public static double GetDotProduct3D(double xOne, double yOne, double zOne, double xTwo, double yTwo, double zTwo) => (xOne * xTwo) + (yOne * yTwo) + (zOne * zTwo);
    /// <summary>
    /// Calculates the magnitude (length) of a 2D vector.
    /// </summary>
    /// <param name="x">The X-component of the vector.</param>
    /// <param name="y">The Y-component of the vector.</param>
    /// <returns>The magnitude of the 2D vector.</returns>
    public static double GetMagnitude(double x, double y) => Math.Sqrt((x * x) + (y * y));
    /// <summary>
    /// Calculates the magnitude (length) of a 3D vector.
    /// </summary>
    /// <param name="x">The X-component of the vector.</param>
    /// <param name="y">The Y-component of the vector.</param>
    /// <param name="z">The Z-component of the vector.</param>
    /// <returns>The magnitude of the 3D vector.</returns>
    public static double GetMagnitude3D(double x, double y, double z) => Math.Sqrt((x * x) + (y * y) + (z * z));
}