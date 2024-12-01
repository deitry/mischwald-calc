namespace ClassLibrary1.Paarhufer;

public class Wildschwein : IPaarhufer
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hasFrischling = ctx.CurrentPlayer.GetAllCards<Frischling>().Count > 0;
        return hasFrischling ? 10 : 0;
    }
}
