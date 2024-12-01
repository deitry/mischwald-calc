namespace Mischwald.Trees;

public class Tanne : T_Tree, ITypedTree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Tanne;

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * All.Count;
    }
}
