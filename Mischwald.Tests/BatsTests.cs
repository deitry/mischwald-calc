using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class BatsTests
{
    [Test]
    public void Bat_test_001()
    {
        var p = new Player
        {
            Trees =
            [
                new DefaultTree
                {
                    Left = new Hufeisennase() { Symbol = TreeTypeEnum.Ahorn },
                }
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(0));
    }
}
