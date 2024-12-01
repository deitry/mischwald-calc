using ClassLibrary1.Insects;

namespace ClassLibrary1.Birds;

public sealed class Gimpel : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var insects = ctx.CurrentPlayer.GetAllCards<IInsect>();

        return 2 * insects.Count;
    }
}
