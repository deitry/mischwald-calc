namespace Mischwald.Trees;

public class Ahorn : T_Tree, IActivePart
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Ahorn;

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.Trees.Count;
    }
}
