namespace ClassLibrary1.Birds;

/// <summary>
/// Дятел
/// </summary>
public class Buntspecht : IBird
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.HasMostOfTrees ? 10 : 0;
    }

    public int GetTypePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
