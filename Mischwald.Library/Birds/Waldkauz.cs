﻿using Mischwald.Trees;

namespace Mischwald.Birds;

/// <summary>
/// Сова
/// </summary>
public class Waldkauz : Bird, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx) => 5;
}
