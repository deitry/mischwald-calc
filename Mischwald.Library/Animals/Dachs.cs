using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Барсук
/// </summary>
public class Dachs : AbstractAnimal, ILeftRight, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2;
    }
}
