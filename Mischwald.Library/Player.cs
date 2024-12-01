using Mischwald.Trees;

namespace Mischwald;

public class Player
{
    public int GetPoints(PointsCalculationContext ctx)
    {
        var allCards = GetAllCards();
        var total = allCards.Sum(c => c.GetInstancePoints(ctx));

        var distinctTypes = allCards.DistinctBy(c => c.GetType());
        total += distinctTypes.Sum(type => type.GetTypePoints(ctx));

        return total;
    }

    /// <summary>
    /// Вообще все карты этого игрока
    /// </summary>
    public List<IActivePart> GetAllCards() => GetAllCards<IActivePart>();

    /// <summary>
    /// Все карты определённого типа
    /// </summary>
    public List<IActivePart> GetAllCards<T>()
        where T : IActivePart
    {
        var total = new List<IActivePart>(Trees.OfType<T>().OfType<IActivePart>());

        total.AddRange(Trees.SelectMany(t => t.All.OfType<T>()).OfType<IActivePart>());

        return total;
    }

    public List<T_Tree> Trees { get; init; } = new();

    public List<IActivePart> GetAllCards(Func<IActivePart, bool> predicate)
    {
        return GetAllCards().Where(predicate).ToList();
    }
}
