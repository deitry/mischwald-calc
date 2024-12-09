using Mischwald.Trees;

namespace Mischwald.Paarhufer;

public class Wildschwein : Paarhufer
{
    public T_Tree? Parent { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hasFrischling = ctx.CurrentPlayer.GetAllCards<Frischling>().Count > 0;
        return hasFrischling ? 10 : 0;
    }
}
