using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald.Animals;

public class Feldhase(FeldhaseStack stack) : IAnimal
{
    public T_Tree? Parent { get; set; } = stack.Parent;

    public FeldhaseStack? ParentStack { get; set; } = stack;

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }
}
