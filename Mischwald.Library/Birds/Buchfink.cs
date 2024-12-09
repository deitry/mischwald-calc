using Mischwald.Trees;

namespace Mischwald.Birds;

public class Buchfink : Bird
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return Parent is Buche ? 5 : 0;
    }
}
