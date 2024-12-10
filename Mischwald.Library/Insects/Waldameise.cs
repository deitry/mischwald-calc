using Mischwald.Trees;

namespace Mischwald.Insects;

/// <summary>
/// Муравей
/// </summary>
public class Waldameise : Insect, IBottom, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var totalBottom = ctx.CurrentPlayer.Trees.Sum(t => t.Bottom?.UnderlyingCards.Count ?? 0);
        return 2 * totalBottom;
    }
}
