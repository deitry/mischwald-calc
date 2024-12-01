using Mischwald.Paarhufer.Hirsch;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Luchs : IAnimal, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hasReh = ctx.CurrentPlayer.GetAllCards<Reh>().Count > 0;

        return hasReh ? 10 : 0;
    }
}
