using ClassLibrary1;
using ClassLibrary1.AnimalsAndPlants;

namespace TestProject1;

public class HaresTests
{
    [Test]
    [TestCase(1, 1)]
    [TestCase(2, 4)]
    [TestCase(3, 9)]
    public void User_has_hares_in_one_spot(int hares, int expectedPoints)
    {
        var player = new Player
        {
            Trees = [
                new Eiche
                {
                    Left = new Feldhase
                    {
                        Count = hares,
                    },
                }
            ],
        };

        var ctx = new GameContext
        {
            Players = [
                player
            ],
        };

        Assert.That(ctx.GetPoints(player), Is.EqualTo(expectedPoints));
    }

    [Test]
    [TestCase(1, 3)]
    [TestCase(2, 8)]
    [TestCase(3, 15)]
    public void User_has_hares_in_one_spot_and_fuchs(int hares, int expectedPoints)
    {
        var player = new Player
        {
            Trees = [
                new Eiche
                {
                    Left = new Feldhase
                    {
                        Count = hares,
                    },
                    Right = new Fuchs(),
                }
            ],
        };

        var ctx = new GameContext
        {
            Players = [
                player
            ],
        };

        Assert.That(ctx.GetPoints(player), Is.EqualTo(expectedPoints));
    }

    [Test]
    [TestCase(1, 0, 1)]
    [TestCase(0, 2, 4)]
    [TestCase(1, 1, 4)]
    [TestCase(1, 3, 16)]
    public void User_has_hares_in_two_spots(int haresOnFirstTree, int haresOnSecondTree, int expectedPoints)
    {
        var player = new Player
        {
            Trees = [
                new Eiche
                {
                    Left = new Feldhase
                    {
                        Count = haresOnFirstTree,
                    },
                },
                new Eiche
                {
                    Right = new Feldhase
                    {
                        Count = haresOnSecondTree,
                    },
                },
            ],
        };

        Assert.That(GameContext.CalculatePoints(player), Is.EqualTo(expectedPoints));
    }
}
