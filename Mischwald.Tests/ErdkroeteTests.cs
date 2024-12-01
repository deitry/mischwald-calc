using Mischwald.Lizards;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class ErdkroeteTests
{
    [Test]
    public void One_erdkroete_doesnt_give_points()
    {
        var p = new Player
        {
            Trees =
            [
                new DefaultTree
                {
                    Bottom = new ErdkroeteStack(count: 1),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(0));
    }

    [Test]
    public void Two_erdkroete_on_different_trees_dont_give_points()
    {
        var p = new Player
        {
            Trees =
            [
                new DefaultTree
                {
                    Bottom = new ErdkroeteStack(count: 1),
                },
                new DefaultTree
                {
                    Bottom = new ErdkroeteStack(count: 1),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(0));
    }

    public void Two_erdkroete_give_points()
    {
        var p = new Player
        {
            Trees =
            [
                new DefaultTree
                {
                    Bottom = new ErdkroeteStack(count: 2),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(10));
    }
}
