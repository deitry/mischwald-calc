using Mischwald.Animals;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class TanneTests
{
    [Test]
    public void Empty_tanne()
    {
        var p = new Player
        {
            Trees =
            [
                new Tanne(),
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(0));
    }

    [Test]
    public void Tanne_with_single_bear()
    {
        var p = new Player
        {
            Trees =
            [
                new Tanne
                {
                    Left = new Braunbaer() {Symbol = TreeTypeEnum.Ahorn},
                }
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(2));
    }

    [Test]
    public void Tanne_with_hares()
    {
        var p = new Player
        {
            Trees =
            [
                new Tanne
                {
                    Left = new FeldhaseStack(Enumerable.Repeat(
                        new Feldhase { Symbol = TreeTypeEnum.Ahorn }, 3).ToList()),
                }
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(6 + 3 * 3));
    }
}
