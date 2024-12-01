using Mischwald;
using Mischwald.Trees;

namespace TestProject1;

public class BucheTests
{
    [Test]
    [TestCase(0, 0)]
    [TestCase(1, 0)]
    [TestCase(3, 0)]
    [TestCase(4, 20)]
    [TestCase(10, 50)]
    public void Player_has_buchen(int count, int expectedPoints)
    {
        var p = new Player
        {
            Trees = Enumerable.Repeat<T_Tree>(new Buche(), count).ToList(),
        };

        var buchen = p.GetAllCards(c => c.TreeType == TreeTypeEnum.Buche);

        Assert.That(buchen, Has.Count.EqualTo(count));

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(expectedPoints));
    }
}
