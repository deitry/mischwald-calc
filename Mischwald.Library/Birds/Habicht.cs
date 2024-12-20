﻿using Mischwald.Trees;

namespace Mischwald.Birds;

public class Habicht : Bird, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 3 * ctx.CurrentPlayer.GetAllCards<Bird>().Count;
    }
}
