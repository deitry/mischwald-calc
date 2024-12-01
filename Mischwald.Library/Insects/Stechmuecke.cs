using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Insects;

public class Stechmuecke : IInsect, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<IBat>().Count;
    }
}
