namespace ClassLibrary1;

public class Eiche : T_Tree
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var distinctTrees = ctx.CurrentPlayer.Trees.DistinctBy(t => t.TreeType);
        return distinctTrees.Count() > 8 ? 10 : 0;
    }

    public override TreeTypeEnum TreeType { get; }
}
