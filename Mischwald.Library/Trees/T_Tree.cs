namespace Mischwald.Trees;

public interface ITypedTree : IActivePart;

public abstract class T_Tree : IActivePart
{
    public bool Full => Top != null && Bottom != null && Left != null && Right != null;

    private readonly ITop? _top;

    public ITop? Top
    {
        get => _top;
        init
        {
            _top = value;

            if (_top != null)
                _top.Parent = this;
        }
    }

    private readonly IBottom? _bottom;
    public IBottom? Bottom
    {
        get => _bottom;
        init
        {
            _bottom = value;

            if (_bottom != null)
                _bottom.Parent = this;
        }
    }

    private readonly ILeftRight? _left;
    public ILeftRight? Left
    {
        get => _left;
        init
        {
            _left = value;

            if (_left != null)
                _left.Parent = this;
        }
    }

    private readonly ILeftRight? _right;
    public ILeftRight? Right
    {
        get => _right;
        init
        {
            _right = value;

            if (_right != null)
                _right.Parent = this;
        }
    }

    public List<IChild> All
    {
        get
        {
            var result = new List<IChild>();

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
