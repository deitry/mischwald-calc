using ClassLibrary1.AnimalsAndPlants;

namespace ClassLibrary1;

public class Ahorn : T_Tree, IActivePart
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Ahorn;

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count * 1;
    }
}
