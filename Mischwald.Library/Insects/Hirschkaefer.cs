using Mischwald.Animals;
using Mischwald.Trees;

namespace Mischwald.Insects;

/// <summary>
/// Жук-олень
/// </summary>
public class Hirschkaefer : Insect, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<AbstractAnimal>().Count;
    }
}
