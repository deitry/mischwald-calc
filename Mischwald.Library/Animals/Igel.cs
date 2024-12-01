using Mischwald.Insects.Butterflies;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Igel : IBottom, IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var butterflies = ctx.CurrentPlayer.GetAllCards<Butterfly>();
        return 2 * butterflies.Count;
    }
}
