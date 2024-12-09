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
                    Left = new Wildschwein() {Symbol = TreeTypeEnum.Ahorn},
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
                    Left = new Wildschwein() {Symbol = TreeTypeEnum.Ahorn},
                    Right = new Frischling() {Symbol = TreeTypeEnum.Ahorn},
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(11));
    }
}
