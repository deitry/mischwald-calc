using ClassLibrary1.Insects;

namespace ClassLibrary1.Butterflies;

public class Butterfly : IInsect, ITop
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 0;
    }

    public int GetTypePoints(PointsCalculationContext ctx)
    {
        var allButterflies = ctx.CurrentPlayer.GetAllCards<Butterfly>();
        var distinctTypes = allButterflies.DistinctBy(t => t.GetType());

        return distinctTypes.Count() switch
        {
            1 => 0,
            2 => 3,
            3 => 6,
            4 => 12,
            >=5 => 20,
            _ => 0,
        };
    }
}
