using Mischwald.Trees;

namespace Mischwald.Plants;

public class Moos : Plant, IBottom
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count >= 10 ? 10 : 0;
    }
}
