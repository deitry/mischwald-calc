using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public abstract class Hirsch : Paarhufer
{
    public abstract int GetInstancePoints(PointsCalculationContext ctx);

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
