namespace ClassLibrary1.Insects;

public class Waldameise : IInsect, IBottom
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var totalBottom = ctx.CurrentPlayer.Trees.Sum(t => t.Bottom?.UnderlyingCards.Count ?? 0);
        return 2 * totalBottom;
    }
}
