using Mischwald.Trees;

namespace Mischwald.Paarhufer;

public class Frischling : IPaarhufer
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
