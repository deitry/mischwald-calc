using System.Diagnostics;

namespace Mischwald.Trees;

public class Eiche : T_Tree, ITypedTree, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.HasAllTypesOfTrees ? 10 : 0;
    }

    public override TreeTypeEnum TreeType => TreeTypeEnum.Eiche;
}
