using Mischwald.Trees;

namespace Mischwald.Animals;

public class Eichhoernchen : AbstractAnimal, ITop, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return Parent?.TreeType == TreeTypeEnum.Eiche ? 5 : 0;
    }
}
