using ClassLibrary1.AnimalsAndPlants;

namespace ClassLibrary1;

public abstract class T_Tree : IActivePart
{
    public bool Full => Top != null && Bottom != null && Left != null && Right != null;

    private readonly IAnimalOrPlant? _top;

    public IAnimalOrPlant? Top
    {
        get => _top;
        init
        {
            _top = value;

            if (_top != null)
                _top.Parent = this;
        }
    }

    private readonly IAnimalOrPlant? _bottom;
    public IAnimalOrPlant? Bottom
    {
        get => _bottom;
        init
        {
            _bottom = value;

            if (_bottom != null)
                _bottom.Parent = this;
        }
    }

    private readonly IAnimalOrPlant? _left;
    public IAnimalOrPlant? Left
    {
        get => _left;
        init
        {
            _left = value;

            if (_left != null)
                _left.Parent = this;
        }
    }

    private readonly IAnimalOrPlant? _right;
    public IAnimalOrPlant? Right
    {
        get => _right;
        init
        {
            _right = value;

            if (_right != null)
                _right.Parent = this;
        }
    }

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
