namespace ClassLibrary1.AnimalsAndPlants;

/// <summary>
/// Крот
/// </summary>
public class Maulwurf : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
