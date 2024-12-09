using Mischwald.Trees;

namespace Mischwald.Insects.Butterflies;

public class Butterfly : Insect, ITop
{
    public override int GetTypePoints(PointsCalculationContext ctx)
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
