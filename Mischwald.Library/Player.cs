using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Mischwald.Animals;
using Mischwald.Insects;
using Mischwald.Insects.Butterflies;
using Mischwald.Lizards;
using Mischwald.Paarhufer.Hirsch;
using Mischwald.Plants;
using Mischwald.Trees;
using NUnit.Framework;

namespace Mischwald;

public class Player
{
    public string PlayerName { get; init; } = "TestPlayer";
    public int CardsInHoehle { get; set; }

    public int GetPoints(PointsCalculationContext ctx)
    {
        var intermediate = IntermediateTotal.From(ctx);

        var allCards = GetAllCards();
        var total = allCards.Sum(c => c.GetInstancePoints(ctx));

        total += Butterfly.GetTypePoints(ctx);
        total += Gluewuermchen.GetTypePoints(ctx);
        total += Feuersalamander.GetTypePoints(ctx);
        total += Kastanie.GetTypePoints(ctx);

        Debug.Assert(intermediate.TotalPoints == total);

        total += CardsInHoehle;

        return total;
    }

    /// <summary>
    /// Вообще все карты этого игрока
    /// </summary>
    public IReadOnlyCollection<IActivePart> GetAllCards() => GetAllCards<IActivePart>();

    /// <summary>
    /// Все карты определённого типа
    /// </summary>
    public IReadOnlyCollection<IActivePart> GetAllCards<T>() where T : IActivePart => GetAllCards(typeof(T));

    public List<T_Tree> Trees { get; init; } = [];

    public IReadOnlyCollection<IActivePart> GetAllCards(Func<IActivePart, bool> predicate)
    {
        return GetAllCards().Where(predicate).ToList();
    }

    public bool HasAllTypesOfTrees
    {
        get
        {
            var distinctTrees = Trees.Where(t => t.TreeType != TreeTypeEnum.None).DistinctBy(t => t.TreeType).ToList();

            return distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Ahorn)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Tanne)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Birke)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Buche)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Douglasie)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Eiche)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Kastanie)
                && distinctTrees.Any(t => t.TreeType == TreeTypeEnum.Linde);
        }
    }

    public IReadOnlyCollection<IActivePart> GetAllCards(Type type)
    {
        var total = new List<IActivePart>(Trees.OfType(type).NotNull());

        total.AddRange(Trees.SelectMany(t => t.All.OfType(type)).OfType<IActivePart>());

        return total;
    }
}
