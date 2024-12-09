using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Барсук
/// </summary>
public class Dachs : IAnimal, ILeftRight
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2;
    }
}
