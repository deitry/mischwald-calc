using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public class Reh : Hirsch
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards().Where(c => c.TreeType == this.Symbol).ToList().Count;
    }
}
