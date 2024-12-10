namespace Mischwald;

public interface ITypePoints
{
    /// <summary>
    /// Сколько дают все карты такого типа
    /// </summary>
    public static abstract int GetTypePoints(PointsCalculationContext ctx);
}
