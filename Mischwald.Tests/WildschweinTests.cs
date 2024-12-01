using Mischwald.Paarhufer;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class WildschweinTests
{
    [Test]
    public void Player_has_only_wildschwein()
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
    public void Player_has_wildschwein_and_frischling()
    {
        var player = new Player
        {
            Trees = [
                new DefaultTree
                {
                    Left = new Wildschwein(),
                    Right = new Frischling(),
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(11));
    }
}
