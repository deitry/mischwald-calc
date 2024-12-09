using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Куница
/// </summary>
public class Steinmarder : IAnimal, ILeftRight
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count(t => t.Full);
    }
}
