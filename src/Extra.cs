namespace GeometrySharp;

internal static class Extra
{
    internal const double Precision = 0.000001;
    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="DivideByZeroException"></exception>
    internal static void ThrowDbz() =>
        throw new DivideByZeroException("The slope is undefined for a vertical line.");
    internal static void ThrowIdenticalPoints() =>
        throw new ArgumentException("Both points are identical. Operation requires two distinct points.");
    internal static void ThrowInvalidHypotenuse() =>
        throw new ArgumentException("Hypotenuse must be greater than the known leg.");
    internal static void ThrowInvalidAngles() =>
        throw new ArgumentException("The sum of the angles must be less than 180 degrees, and each angle must be positive.");
    internal static void ThrowInvalidTriangleAngle() =>
        throw new ArgumentException("Angle must be between 0 and 180 degrees");
    internal static void ThrowInvalidDimension() =>
        throw new ArgumentException("Side length must be greater than zero.");
}