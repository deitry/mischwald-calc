﻿namespace ClassLibrary1.AnimalsAndPlants;

/// <summary>
/// Куница
/// </summary>
public class Steinmarder : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.Trees.Count(t => t.Full);
    }
}
