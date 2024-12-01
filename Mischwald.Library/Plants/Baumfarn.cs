using Mischwald.Lizards;
using Mischwald.Trees;

namespace Mischwald.Plants;

public class Baumfarn : IPlant
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 6 * ctx.CurrentPlayer.GetAllCards<ILizard>().Count;
    }
}
