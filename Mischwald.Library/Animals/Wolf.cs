﻿using Mischwald.Paarhufer.Hirsch;
using Mischwald.Trees;

namespace Mischwald.Animals;

public sealed class Wolf : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hirschen = ctx.CurrentPlayer.GetAllCards<Hirsch>();

        return 5 * hirschen.Count;
    }
}