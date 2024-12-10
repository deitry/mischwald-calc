using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Siebenschlaefer : AbstractAnimal, ILeftRight, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        if (Parent == null)
            return 0;

        if (Parent.Right == this && Parent.Left is Bat)
            return 15;

        if (Parent.Left == this && Parent.Right is Bat)
            return 15;

        return 0;
    }
}
