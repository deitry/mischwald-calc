using ClassLibrary1;
using ClassLibrary1.AnimalsAndPlants;

namespace TestProject1;

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
                    Left = new Braunbaer(),
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
                    Left = new Feldhase(count: 3),
                }
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(6 + 3 * 3));
    }
}
