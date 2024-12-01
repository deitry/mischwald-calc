namespace ClassLibrary1;

public class Eiche : T_Tree
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var distinctTrees = ctx.CurrentPlayer.Trees
            .Where(t => t.TreeType != TreeTypeEnum.None)
            .DistinctBy(t => t.TreeType);

        return distinctTrees.Count() > 8 ? 10 : 0;
    }

    public override TreeTypeEnum TreeType => TreeTypeEnum.Eiche;
}
