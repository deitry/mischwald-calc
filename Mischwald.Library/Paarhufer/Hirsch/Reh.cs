using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public class Reh<T> : Hirsch
    where T : ITypedTree
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<T>().Count;
    }
}
