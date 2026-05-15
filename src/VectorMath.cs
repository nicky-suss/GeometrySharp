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
    /// <summary>
    /// Calculates the cross product of two 3D vectors.
    /// </summary>
    /// <param name="x1">The X-component of the first vector.</param>
    /// <param name="y1">The Y-component of the first vector.</param>
    /// <param name="z1">The Z-component of the first vector.</param>
    /// <param name="x2">The X-component of the second vector.</param>
    /// <param name="y2">The Y-component of the second vector.</param>
    /// <param name="z2">The Z-component of the second vector.</param>
    /// <returns>A tuple representing the resulting 3D vector perpendicular to both input vectors</returns>
    public static (double x, double y, double z) GetCrossProduct(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return (
            (y1 * z2) - (z1 * y2),
            (z1 * x2) - (x1 * z2),
            (x1 * y2) - (y1 * x2)
        );

    }
    /// <summary>
    /// Calculates the angle between two vectors in radians using their dot product and magnitudes.
    /// </summary>
    /// <param name="dotProduct">The dot product of the two vectors.</param>
    /// <param name="lengthA">The magnitude (length) of the first vector.</param>
    /// <param name="lengthB">The magnitude (length) of the second vector.</param>
    /// <returns>The angle between the vectors in radians.</returns>
    /// <exception cref="DivideByZeroException">Thrown when the magnitude of either vector is zero.</exception>
    public static double GetAngleBetween(double dotProduct, double lengthA, double lengthB)
    {
        if (lengthA == 0 || lengthB == 0)
            throw new DivideByZeroException("Cannot compute angle: one or both vector lengths are zero.");
        double A = dotProduct / (lengthA * lengthB);
        A = Math.Clamp(A, -1.0, 1.0);
        return Math.Acos(A);
    }
}