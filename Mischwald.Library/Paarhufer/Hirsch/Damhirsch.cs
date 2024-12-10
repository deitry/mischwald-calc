using Mischwald.Paarhufer;
using Mischwald.Paarhufer.Hirsch;

namespace Mischwald.Animals;

public class Damhirsch : Hirsch, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var paarhuferCount = ctx.CurrentPlayer.GetAllCards<Paarhufer.Paarhufer>().Count;
        return 3 * paarhuferCount;
    }
}
