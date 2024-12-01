using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public sealed class Rothirsch : Hirsch
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var trees = ctx.CurrentPlayer.GetAllCards<T_Tree>();
        var plants = ctx.CurrentPlayer.GetAllCards<IPlant>();

        return 1 * (trees.Count + plants.Count);
    }
}
