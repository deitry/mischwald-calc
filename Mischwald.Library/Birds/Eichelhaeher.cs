using Mischwald.Trees;

namespace Mischwald.Birds;

public class Eichelhaeher : Bird, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3;
    }
}
