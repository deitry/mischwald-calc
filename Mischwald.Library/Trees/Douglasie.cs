namespace Mischwald.Trees;

public class Douglasie : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Douglasie;

    public override int GetInstancePoints(PointsCalculationContext ctx) => 5;
}
