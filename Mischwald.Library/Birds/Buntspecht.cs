using Mischwald.Trees;

namespace Mischwald.Birds;

/// <summary>
/// Дятел
/// </summary>
public class Buntspecht : Bird
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.HasMostOfTrees ? 10 : 0;
    }

    public override int GetTypePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
