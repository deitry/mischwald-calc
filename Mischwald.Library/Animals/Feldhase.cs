using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Feldhase : IAnimal
{
    public FeldhaseStack? ParentStack { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }
}
