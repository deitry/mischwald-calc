using Mischwald.Insects;
using Mischwald.Trees;

namespace Mischwald.Birds;

public sealed class Gimpel : Bird
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var insects = ctx.CurrentPlayer.GetAllCards<Insect>();

        return 2 * insects.Count;
    }
}
