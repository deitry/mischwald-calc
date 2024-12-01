namespace ClassLibrary1;

public class Birke : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Birke;

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1;
    }
}
