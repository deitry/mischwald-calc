using Mischwald.Trees;

namespace Mischwald.Paarhufer;

public class Frischling : Paarhufer
{
    public T_Tree? Parent { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1;
    }

    public override int GetTypePoints(PointsCalculationContext ctx) => 0;
}
