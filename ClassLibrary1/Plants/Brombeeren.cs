namespace ClassLibrary1.Plants;

public class Brombeeren : IPlant
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<IPlant>().Count;
    }
}
