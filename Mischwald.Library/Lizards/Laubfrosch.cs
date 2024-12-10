using Mischwald.Insects;
using Mischwald.Trees;

namespace Mischwald.Lizards;

public class Laubfrosch : Lizard, IBottom, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5 * ctx.CurrentPlayer.GetAllCards<Stechmuecke>().Count;
    }
}
