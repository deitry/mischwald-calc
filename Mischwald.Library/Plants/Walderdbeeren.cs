using Mischwald.Trees;

namespace Mischwald.Plants;

public class Walderdbeeren : IPlant
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.HasAllTypesOfTrees ? 10 : 0;
    }
}
