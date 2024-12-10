using Mischwald.Trees;

namespace Mischwald.Birds;

/// <summary>
/// Дятел
/// </summary>
public class Buntspecht : Bird, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.HasMostOfTrees ? 10 : 0;
    }
}
