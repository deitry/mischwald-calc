using Mischwald.Animals;
using Mischwald.Trees;

namespace Mischwald.Insects;

/// <summary>
/// Жук-олень
/// </summary>
public class Hirschkaefer : IInsect
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<IAnimal>().Count;
    }
}
