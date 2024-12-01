using Mischwald.Trees;

namespace Mischwald.Mushrooms;

public class Mushroom : IActivePart, IBottom
{
    public T_Tree? Parent { get; set; }
}
