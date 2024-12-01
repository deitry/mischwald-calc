using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public abstract class Hirsch : IPaarhufer
{
    public T_Tree? Parent { get; set; }

    public abstract int GetInstancePoints(PointsCalculationContext ctx);

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
