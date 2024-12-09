using Mischwald.Insects.Butterflies;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Igel : IAnimal, IBottom
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var butterflies = ctx.CurrentPlayer.GetAllCards<Butterfly>();
        return 2 * butterflies.Count;
    }
}
