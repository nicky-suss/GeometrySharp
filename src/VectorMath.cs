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
}