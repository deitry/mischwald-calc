using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Крот
/// </summary>
public class Maulwurf : AbstractAnimal, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
