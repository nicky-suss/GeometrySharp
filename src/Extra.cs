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
}