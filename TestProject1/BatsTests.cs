using ClassLibrary1;
using ClassLibrary1.Bats;
using ClassLibrary1.Butterflies;

namespace TestProject1;

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
                    Left = new Hufeisennase(),
                }
            ],
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(0));
    }
}
