using Mischwald.Trees;

namespace Mischwald.Animals;

public class Eichhoernchen : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return Parent?.TreeType == TreeTypeEnum.Eiche ? 5 : 0;
    }
}
