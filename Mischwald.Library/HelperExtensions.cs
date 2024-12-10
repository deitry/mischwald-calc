namespace Mischwald;

public static class HelperExtensions
{
    public static bool IsEmpty(this string? s) => string.IsNullOrWhiteSpace(s);
    public static bool HasValue(this string? s) => ! s.IsEmpty();

    public static IEnumerable<T> NotNull<T>(this IEnumerable<T?> source) => source.OfType<T>();

    public static IEnumerable<T> OfType<T>(this IEnumerable<T?> source, Type type)
    {
        return source.Where(i => type.IsInstanceOfType(i)).NotNull();
    }
}
