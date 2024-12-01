﻿using Mischwald.Trees;

namespace Mischwald.Lizards;

/// <summary>
/// Черепаха
/// </summary>
public class Sumpshildkroete : ILizard
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5;
    }
}