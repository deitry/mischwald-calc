using Mischwald.Animals;
using Mischwald.Trees;

namespace Mischwald.Insects;

/// <summary>
/// Жук-олень
/// </summary>
public class Hirschkaefer : Insect
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<IAnimal>().Count;
    }
}
