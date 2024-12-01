using Mischwald.Trees;

namespace Mischwald.Birds;

/// <summary>
/// Дятел
/// </summary>
public class Buntspecht : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.HasMostOfTrees ? 10 : 0;
    }

    public int GetTypePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
