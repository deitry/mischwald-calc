namespace ClassLibrary1.Paarhufer.Hirsch;

public abstract class Hirsch : IPaarhufer
{
    public abstract int GetInstancePoints(PointsCalculationContext ctx);

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
