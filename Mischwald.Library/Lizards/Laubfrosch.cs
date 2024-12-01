using Mischwald.Insects;
using Mischwald.Trees;

namespace Mischwald.Lizards;

public class Laubfrosch : ILizard, IBottom
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5 * ctx.CurrentPlayer.GetAllCards<Stechmuecke>().Count;
    }
}
