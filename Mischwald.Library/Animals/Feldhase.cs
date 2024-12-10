using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Feldhase : AbstractAnimal, ICardName
{
    public FeldhaseStack? ParentStack { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }
}
