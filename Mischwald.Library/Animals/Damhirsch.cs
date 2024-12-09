using Mischwald.Paarhufer;
using Mischwald.Paarhufer.Hirsch;

namespace Mischwald.Animals;

public class Damhirsch : Hirsch
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<Paarhufer.Paarhufer>().Count;
    }
}
