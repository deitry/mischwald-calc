namespace ClassLibrary1;

public class Douglasie : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Douglasie;

    public int GetInstancePoints(PointsCalculationContext ctx) => 5;
}
