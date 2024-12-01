using Mischwald.Trees;

namespace Mischwald.Animals;

/// <summary>
/// Лиса
/// </summary>
public class Fuchs : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
