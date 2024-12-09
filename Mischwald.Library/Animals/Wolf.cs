using Mischwald.Paarhufer.Hirsch;
using Mischwald.Trees;

namespace Mischwald.Animals;

public sealed class Wolf : IAnimal, ILeftRight
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hirschen = ctx.CurrentPlayer.GetAllCards<Hirsch>();

        return 5 * hirschen.Count;
    }
}
