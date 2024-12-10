using Mischwald.Trees;

namespace Mischwald.Birds;

public class Buchfink : Bird, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return Parent is Buche ? 5 : 0;
    }
}
