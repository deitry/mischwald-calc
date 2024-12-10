using Mischwald.Trees;

namespace Mischwald.Plants;

public class Brombeeren : Plant, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Plant>().Count;
    }
}
