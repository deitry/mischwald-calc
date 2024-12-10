using Mischwald.Trees;

namespace Mischwald.Lizards;

/// <summary>
/// Черепаха
/// </summary>
public class Sumpshildkroete : Lizard, IBottom, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5;
    }
}
