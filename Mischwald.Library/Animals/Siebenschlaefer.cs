using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Siebenschlaefer : IAnimal, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        if (Parent == null)
            return 0;

        if (Parent.Right == this && Parent.Left is IBat)
            return 15;

        if (Parent.Left == this && Parent.Right is IBat)
            return 15;

        return 0;
    }
}
