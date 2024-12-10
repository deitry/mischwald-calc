using Mischwald.Trees;

namespace Mischwald.Plants;

public class Moos : Plant, IBottom, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count >= 10 ? 10 : 0;
    }
}
