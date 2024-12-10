namespace Mischwald;

public record IntermediateResult
{
    public static IntermediateResult OfType(PointsCalculationContext ctx, Type type)
    {
        var cards = ctx.CurrentPlayer.GetAllCards(type);

        return new IntermediateResult(type, cards, ctx);
    }

    private IntermediateResult(Type type, IReadOnlyCollection<IActivePart> cards, PointsCalculationContext ctx)
    {
        Type = type;
        Cards = cards.Select(c => new CalculatedCard(c, c.GetInstancePoints(ctx))).ToList();
    }

    public Type Type { get; }

    public IReadOnlyCollection<CalculatedCard> Cards { get; }

    public int TotalPoints
    {
        get
        {
            var total = Cards.Sum(c => c.Points);
            return total;
        }
    }

    public string CardName => Type.Name;

    public override string ToString()
    {
        if (Cards.Count == 0)
            return $"{CardName} : no cards";

        var cardPoints = Cards.Select(c => c.Points);
        var enumerated = string.Join(" + ", cardPoints);

        return $"{CardName} : {TotalPoints} = {enumerated}";
    }
};
