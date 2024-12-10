using System.Diagnostics;
using System.Reflection;
using Mischwald.Animals;
using Mischwald.Insects;
using Mischwald.Insects.Butterflies;
using Mischwald.Lizards;
using Mischwald.Paarhufer.Hirsch;
using Mischwald.Plants;
using Mischwald.Trees;

namespace Mischwald;

public class IntermediateTotal
{
    /// <summary>
    /// Calculate intermediate results considering current player in given context
    /// </summary>
    public static IntermediateTotal From(PointsCalculationContext ctx)
    {
        var specificTypes = Assembly.GetAssembly(typeof(ICardName))
                ?.DefinedTypes.Where(t => t.IsAssignableTo(typeof(ICardName)) && t != typeof(ICardName) && !t.IsAssignableTo(typeof(ITypePoints)))
                .OrderBy(t => t.Name)
                .ToList()
            ?? [];

        var intermediateResults = specificTypes
            .Select(t => IntermediateResult.OfType(ctx, t))
            .OrderBy(t => t.CardName)
            .ToList();

        var allCards = ctx.CurrentPlayer.GetAllCards().Where(card => card is not ITypePoints).ToList();
        foreach (var t in specificTypes)
        {
            allCards = allCards.Except(allCards.Where(c => t.IsInstanceOfType(c))).ToList();
        }

        Debug.Assert(allCards.Count == 0, "Probably some cards doesn't have ICardName implemented");

        return new IntermediateTotal(intermediateResults, ctx);
    }

    private IntermediateTotal(IReadOnlyCollection<IntermediateResult> results, PointsCalculationContext ctx)
    {
        IntermediateResultsList = results;
        IntermediateSetResults = [
            IntermediateSetResult.From<Butterfly>(ctx),
            IntermediateSetResult.From<Gluewuermchen>(ctx),
            IntermediateSetResult.From<Feuersalamander>(ctx),
            IntermediateSetResult.From<Kastanie>(ctx),
        ];
    }

    public List<IntermediateSetResult> IntermediateSetResults { get; set; }

    public IReadOnlyCollection<IntermediateResult> IntermediateResultsList { get; }

    public IReadOnlyCollection<IntermediateResult> Trees => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(ITypedTree))).ToList();

    public IReadOnlyCollection<IntermediateResult> Animals => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(AbstractAnimal))).ToList();

    public IReadOnlyCollection<IntermediateResult> Hirsche => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(Hirsch))).ToList();

    public IReadOnlyCollection<IntermediateResult> Insects => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(Insect))).ToList();

    public IReadOnlyCollection<IntermediateResult> Lizards => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(Lizard))).ToList();

    public IReadOnlyCollection<IntermediateResult> Plants => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(Plant))).ToList();

    public IReadOnlyCollection<IntermediateResult> Paarhufer => IntermediateResultsList.Where(r => r.Type.IsAssignableTo(typeof(Paarhufer.Paarhufer))).ToList();

    public int TotalCards => IntermediateResultsList.Sum(r => r.Cards.Count);

    public int TotalTypes => IntermediateResultsList.DistinctBy(r => r.CardName).Count();

    public int TotalInstancePoints => IntermediateResultsList.Sum(r => r.TotalPoints);

    public int TotalSetPoints => IntermediateSetResults.Sum(r => r.TotalSetPoints);

    public int TotalPoints => TotalInstancePoints + TotalSetPoints;
}
