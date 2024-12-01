using Mischwald.Trees;

namespace Mischwald;

public interface IAnimalOrPlant : IActivePart
{
    public T_Tree? Parent { get; set; }

    List<IAnimalOrPlant> UnderlyingCards => [this];
}
