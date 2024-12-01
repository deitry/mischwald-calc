namespace Mischwald.Trees;

public class Kastanie : T_Tree, ITypedTree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Kastanie;

    public override int GetTypePoints(PointsCalculationContext ctx)
    {
        var castanie = ctx.CurrentPlayer.GetAllCards(c => c.TreeType == TreeTypeEnum.Kastanie);

        return castanie.Count switch
        {
            1 => 1,
            2 => 4,
            3 => 9,
            4 => 16,
            5 => 25,
            6 => 36,
            >=7 => 49,
            _ => 0,
        };
    }
}
