namespace ClassLibrary1;

public class Buche : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Buche;

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var cards = ctx.CurrentPlayer.GetAllCards();
        return cards.Count(c => c.TreeType == TreeTypeEnum.Buche);
    }
}
