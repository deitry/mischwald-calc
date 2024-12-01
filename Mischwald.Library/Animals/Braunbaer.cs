﻿using Mischwald.Trees;

namespace Mischwald.Animals;

public class Braunbaer : IAnimal, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
