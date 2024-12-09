using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Лиса
/// </summary>
public class Fuchs : IAnimal, ILeftRight
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }

    public override int GetTypePoints(PointsCalculationContext ctx) => 0;
}
