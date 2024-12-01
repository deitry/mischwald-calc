namespace ClassLibrary1.Birds;

public class Habicht : IBird
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<IBird>().Count;
    }
}
