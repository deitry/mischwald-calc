using Mischwald.Lizards;
using Mischwald.Trees;

namespace Mischwald.Plants;

public class Baumfarn : Plant
{
    public T_Tree? Parent { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 6 * ctx.CurrentPlayer.GetAllCards<ILizard>().Count;
    }
}
