namespace ClassLibrary1.Birds;

public class Eichelhaeher : IBird
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3;
    }
}
