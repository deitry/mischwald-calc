﻿namespace ClassLibrary1;

public class Birke : T_Tree
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.Birke;

    public override int GetInstancePoints(PointsCalculationContext ctx) => 1;
}
