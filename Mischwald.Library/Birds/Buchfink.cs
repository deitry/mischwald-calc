using Mischwald.Trees;

namespace Mischwald.Birds;

public class Buchfink : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return Parent is Buche ? 5 : 0;
    }
}
