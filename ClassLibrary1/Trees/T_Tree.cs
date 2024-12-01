using ClassLibrary1.AnimalsAndPlants;

namespace ClassLibrary1;

public abstract class T_Tree : IActivePart
{
    public bool Full => Top != null && Bottom != null && Left != null && Right != null;

    public IAnimalOrPlant? Top { get; init; }

    public IAnimalOrPlant? Bottom { get; init; }

    public IAnimalOrPlant? Left { get; init; }

    public IAnimalOrPlant? Right { get; init; }

    public List<IAnimalOrPlant> All
    {
        get
        {
            var result = new List<IAnimalOrPlant>();

            if (Top != null) result.AddRange(Top.UnderlyingCards);
            if (Bottom != null) result.AddRange(Bottom.UnderlyingCards);
            if (Left != null) result.AddRange(Left.UnderlyingCards);
            if (Right != null) result.AddRange(Right.UnderlyingCards);

            return result;
        }
    }

    public abstract TreeTypeEnum TreeType { get; }

    public virtual int GetInstancePoints(PointsCalculationContext ctx) => 0;

    public virtual int GetTypePoints(PointsCalculationContext ctx) => 0;
}
