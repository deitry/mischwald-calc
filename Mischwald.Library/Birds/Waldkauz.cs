using Mischwald.Trees;

namespace Mischwald.Birds;

/// <summary>
/// Сова
/// </summary>
public class Waldkauz : IBird
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx) => 5;
}
