using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Лиса
/// </summary>
public class Fuchs : AbstractAnimal, ILeftRight, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }
}
