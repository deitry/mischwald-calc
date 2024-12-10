using Mischwald.Trees;

namespace Mischwald.Plants;

public class Walderdbeeren : Plant, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.HasAllTypesOfTrees ? 10 : 0;
    }
}
