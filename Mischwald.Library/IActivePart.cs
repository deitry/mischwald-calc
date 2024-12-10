using Mischwald.Trees;

namespace Mischwald;

/// <summary>
/// Активная сторона карты
/// </summary>
public interface IActivePart
{
    // public List<string> Aliases { get; }
    // TODO: cost
    // TODO: active effect
    // TODO: bonus active effect
    // TODO: triggered effect

    /// <summary>
    /// Сколько даёт каждая карта такого типа
    /// </summary>
    int GetInstancePoints(PointsCalculationContext ctx) => 0;

    TreeTypeEnum TreeType => TreeTypeEnum.None;
    TreeTypeEnum Symbol => TreeType;
}
