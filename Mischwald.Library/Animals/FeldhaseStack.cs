using Mischwald.Trees;

namespace Mischwald.Animals;

public class FeldhaseStack : ILeftRight
{
    public T_Tree? Parent { get; set; }

    public List<IChild> UnderlyingCards { get; set; } = new();

    // public int Count { get; init; }

    public FeldhaseStack(IReadOnlyCollection<Feldhase> feldhases)
    {
        UnderlyingCards.AddRange(feldhases);
    }
}
