using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Куница
/// </summary>
public class Steinmarder : AbstractAnimal, ILeftRight, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5 * ctx.CurrentPlayer.Trees.Count(t => t.Full);
    }
}
