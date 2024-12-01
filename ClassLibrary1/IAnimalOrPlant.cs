namespace ClassLibrary1.AnimalsAndPlants;

public interface IAnimalOrPlant : IActivePart
{
    // public T_Tree Parent { get; init; }
    List<IAnimalOrPlant> UnderlyingCards => [this];
}
