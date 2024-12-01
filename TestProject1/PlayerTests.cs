using Mischwald;
using Mischwald.Animals;
using Mischwald.Insects.Butterflies;
using Mischwald.Trees;

namespace TestProject1;

public class PlayerTests
{
    [Test]
    public void Empty_user_has_no_points()
    {
        var player = new Player();
        var ctx = new GameContext
        {
            Players = [
                player
            ],
        };

        Assert.That(ctx.GetPoints(player), Is.EqualTo(0));
    }

    [Test]
    public void Player_number_of_cards_example001()
    {
        var p = new Player
        {
            Trees =
            [
                new Birke
                {
                    Left = new Feldhase(count: 4),
                    Top = new GrosserFuchs(),
                },
            ],
        };

        Assert.Multiple(() =>
        {
            Assert.That(p.GetAllCards(), Has.Count.EqualTo(6));

            Assert.That(p.GetAllCards<Feldhase>(), Has.Count.EqualTo(4));

            Assert.That(p.GetAllCards<GrosserFuchs>(), Has.Count.EqualTo(1));
        });
    }
}
