using Mischwald.Trees;

namespace Mischwald.Animals;

public class FeldhaseStack(int count = 1) : ILeftRight
{
    public T_Tree? Parent { get; set; }

    public List<IAnimalOrPlant> UnderlyingCards => Enumerable.Repeat<IAnimalOrPlant>(new Feldhase(this), Count).ToList();

    public int Count { get; init; } = count;
}