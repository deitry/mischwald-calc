using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Insects;

public class Stechmuecke : Insect, ILeftRight
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<Bat>().Count;
    }
}
