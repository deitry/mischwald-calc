using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public abstract class Reh : Hirsch;

public class Reh<T> : Reh
    where T : ITypedTree
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<T>().Count;
    }
}
