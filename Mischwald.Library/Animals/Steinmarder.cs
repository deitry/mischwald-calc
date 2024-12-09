using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Куница
/// </summary>
public class Steinmarder : IAnimal, ILeftRight
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count(t => t.Full);
    }
}
