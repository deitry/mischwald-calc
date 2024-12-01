using Mischwald.Trees;

namespace Mischwald.Birds;

public class Eichelhaeher : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3;
    }
}
