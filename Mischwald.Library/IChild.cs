using Mischwald.Trees;

namespace Mischwald;

public interface IChild
{
    public T_Tree? Parent { get; set; }
    public List<IChild> UnderlyingCards => [this];
}
