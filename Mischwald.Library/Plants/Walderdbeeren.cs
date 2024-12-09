using Mischwald.Trees;

namespace Mischwald.Plants;

public class Walderdbeeren : Plant
{
    public T_Tree? Parent { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.HasAllTypesOfTrees ? 10 : 0;
    }
}
