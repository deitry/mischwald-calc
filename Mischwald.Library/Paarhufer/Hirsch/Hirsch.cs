using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public abstract class Hirsch : Paarhufer
{
    public abstract override int GetInstancePoints(PointsCalculationContext ctx);

    public override int GetTypePoints(PointsCalculationContext ctx) => 0;
}
