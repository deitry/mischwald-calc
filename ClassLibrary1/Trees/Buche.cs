using ClassLibrary1.AnimalsAndPlants;

namespace ClassLibrary1;

public class Buche : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Buche;

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var buche = ctx.CurrentPlayer.GetAllCards(c => c.TreeType == TreeTypeEnum.Buche);

        return buche.Count >= 4 ? 5 : 0;
    }
}
