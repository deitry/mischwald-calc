using Mischwald.Animals;
using Mischwald.Paarhufer;
using Mischwald.Paarhufer.Hirsch;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class LuchsTests
{
    [Test]
    public void Player_has_only_Luchs()
    {
        var player = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Wildschwein(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(0));
    }

    [Test]
    public void Player_has_luchs_and_reh()
    {
        var player = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Luchs(),
                    Right = new Reh<Tanne>(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(10));
    }

    [Test]
    public void Player_has_luchs_and_reh_and_proper_tree()
    {
        var player = new Player
        {
            Trees = [
                new Tanne
                {
                    Left = new Luchs(),
                    Right = new Reh<Tanne>(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(10 + 3 * 1 + 2 * 2));
    }

    [Test]
    public void Player_has_luchs_and_two_reh()
    {
        var player = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Luchs(),
                    Right = new Reh<Tanne>(),
                },
                new DefaultTree
                {
                    Right = new Reh<Tanne>(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(10));
    }
}
