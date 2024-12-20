﻿using Mischwald.Trees;

namespace Mischwald.Lizards;

public class Feuersalamander : Lizard, IBottom, ITypePoints, ICardName
{
    public static int GetTypePoints(PointsCalculationContext ctx)
    {
        var salamanders = ctx.CurrentPlayer.GetAllCards<Feuersalamander>();

        return salamanders.Count switch
        {
            1 => 5,
            2 => 15,
            >=3 => 25,
            _ => 0,
        };
    }
}
