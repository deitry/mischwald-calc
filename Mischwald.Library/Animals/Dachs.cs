using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Барсук
/// </summary>
public class Dachs : IAnimal, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2;
    }
}
