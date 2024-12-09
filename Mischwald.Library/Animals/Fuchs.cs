using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Лиса
/// </summary>
public class Fuchs : IAnimal, ILeftRight
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
