using Mischwald.Insects;
using Mischwald.Trees;

namespace Mischwald.Tests;

public class HolzbieneTests
{
    public static IEnumerable<object[]> TestCases()
    {
        yield return
        [
            /* testName */ "Only one buche",
            /* trees */ new List<T_Tree>
            {
                new Buche(),
            },
            /* expectedPoints */ 0,
        ];

        yield return
        [
            /* testName */ "Three buche and one holzbiene",
            /* trees */ new List<T_Tree>
            {
                new Buche(),
                new Buche()
                {
                    Right = new Holzbiene(),
                },
                new Buche(),
            },
            /* expectedPoints */ 15,
        ];

        yield return
        [
            /* testName */ "Two buche and three holzbiene",
            /* trees */ new List<T_Tree>
            {
                new Buche
                {
                    Right = new Holzbiene(),
                },
                new Buche
                {
                    Left = new Holzbiene(),
                    Right = new Holzbiene(),
                },
            },
            /* expectedPoints */ 10,
        ];

        yield return
        [
            /* testName */ "Three buche and one holzbiene on another tree",
            /* trees */ new List<T_Tree>
            {
                new DefaultTree
                {
                    Right = new Holzbiene(),
                },
                new Buche(),
                new Buche(),
                new Buche(),
            },
            /* expectedPoints */ 0,
        ];
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void Buche_and_holzbiene(string testName, List<T_Tree> trees, int expectedPoints)
    {
        var p = new Player
        {
            Trees = trees,
        };

        Assert.That(GameContext.CalculatePoints(p), Is.EqualTo(expectedPoints));
    }
}
