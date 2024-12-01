using Mischwald.Insects;
using Mischwald.Trees;

namespace Mischwald.Birds;

public sealed class Gimpel : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var insects = ctx.CurrentPlayer.GetAllCards<IInsect>();

        return 2 * insects.Count;
    }
}
