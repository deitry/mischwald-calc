namespace ClassLibrary1.Birds;

public class Habicht : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<IBird>().Count;
    }
}
