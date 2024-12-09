using Mischwald.Trees;

namespace Mischwald;

public abstract class AnimalOrPlant : IActivePart, IChild
{
    public required TreeTypeEnum Symbol { get; init; }

    public virtual TreeTypeEnum TreeType => Symbol;

    public T_Tree? Parent { get; set; }

    public List<AnimalOrPlant> UnderlyingCards => [this];

    public virtual int GetInstancePoints(PointsCalculationContext ctx) => 0;

    public virtual int GetTypePoints(PointsCalculationContext ctxs) => 0;
}
