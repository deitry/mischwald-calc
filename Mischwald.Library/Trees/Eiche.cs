using System.Diagnostics;

namespace Mischwald.Trees;

public class Eiche : T_Tree
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var distinctTrees = ctx.CurrentPlayer.Trees
            .Where(t => t.TreeType != TreeTypeEnum.None)
            .DistinctBy(t => t.TreeType);

        var distinctCount = distinctTrees.Count();

        Debug.Assert(distinctCount <= 8, "Unexpected tree type");

        return distinctCount == 8 ? 10 : 0;
    }

    public override TreeTypeEnum TreeType => TreeTypeEnum.Eiche;
}
