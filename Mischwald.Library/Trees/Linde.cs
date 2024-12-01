namespace Mischwald.Trees;

public class Linde : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Linde;

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var currentPlayerCount = ctx.CurrentPlayer.GetAllCards(c => c.TreeType == TreeTypeEnum.Linde).Count;
        var hasMost = ctx.OtherPlayers.All(p => p.GetAllCards(c => c.TreeType == TreeTypeEnum.Linde).Count < currentPlayerCount);

        return hasMost ? 3 : 1;
    }
}
