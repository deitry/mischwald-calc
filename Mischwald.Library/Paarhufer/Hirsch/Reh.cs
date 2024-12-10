using Mischwald.Trees;

namespace Mischwald.Paarhufer.Hirsch;

public class Reh : Hirsch, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var symbolsCount = ctx.CurrentPlayer.GetAllCards().Where(c => c.Symbol == this.Symbol).ToList().Count;
        return 3 * symbolsCount;
    }
}
