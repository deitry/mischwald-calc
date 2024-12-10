using Mischwald.Lizards;
using Mischwald.Trees;

namespace Mischwald.Plants;

public class Baumfarn : Plant, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 6 * ctx.CurrentPlayer.GetAllCards<Lizard>().Count;
    }
}
