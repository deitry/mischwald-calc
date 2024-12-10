using Mischwald.Trees;

namespace Mischwald.Paarhufer;

public class Frischling : Paarhufer, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1;
    }
}
