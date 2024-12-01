namespace ClassLibrary1.Insects;

/// <summary>
/// Муравей
/// </summary>
public class Waldameise : IInsect, IBottom
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var totalBottom = ctx.CurrentPlayer.Trees.Sum(t => t.Bottom?.UnderlyingCards.Count ?? 0);
        return 2 * totalBottom;
    }
}
