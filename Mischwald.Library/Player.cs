using System.Diagnostics;
using Mischwald.Trees;

namespace Mischwald;

public class Player
{
    public int CardsInHoehle { get; set; }

    public int GetPoints(PointsCalculationContext ctx)
    {
        var allCards = GetAllCards();
        var total = allCards.Sum(c => c.GetInstancePoints(ctx));

        var distinctTypes = allCards.DistinctBy(c => c.GetType());
        total += distinctTypes.Sum(type => type.GetTypePoints(ctx));

        total += CardsInHoehle;

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

    public bool HasAllTypesOfTrees
    {
        get
        {
            var distinctTrees = Trees
                .Where(t => t.TreeType != TreeTypeEnum.None)
                .DistinctBy(t => t.TreeType);

            var distinctCount = distinctTrees.Count();

            Debug.Assert(distinctCount <= 8, "Unexpected tree type");

            return distinctCount == 8;
        }
    }
}
