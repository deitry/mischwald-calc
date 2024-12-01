﻿namespace Mischwald.Trees;

public class Birke : T_Tree, ITypedTree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Birke;

    public override int GetInstancePoints(PointsCalculationContext ctx) => 1;
}
