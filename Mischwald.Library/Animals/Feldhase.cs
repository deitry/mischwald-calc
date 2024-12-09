using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Feldhase(FeldhaseStack stack) : IAnimal
{
    public FeldhaseStack? ParentStack { get; set; } = stack;

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }
}
