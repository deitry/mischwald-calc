namespace ClassLibrary1.Paarhufer;

public class Frischling : IPaarhufer
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
