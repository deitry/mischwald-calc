﻿using Mischwald.Animals;
using Mischwald.Paarhufer;
using Mischwald.Paarhufer.Hirsch;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class DamhirschTests
{
    [Test]
    public void Points_only_for_itself()
    {
        var p = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Damhirsch(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(3));
    }

    [Test]
    public void Hirsch_and_not_hirsch()
    {
        var p = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Damhirsch(),
                    Right = new Frischling(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(3 * 2 + 1));
    }

    [Test]
    public void Two_hirsches_on_different_trees()
    {
        var p = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Damhirsch(),
                },
                new DefaultTree
                {
                    Right = new Reh<Tanne>(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(3 * 2));
    }
}