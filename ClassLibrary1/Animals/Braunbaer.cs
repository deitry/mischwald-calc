namespace ClassLibrary1.AnimalsAndPlants;

public class Braunbaer : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 0;
    }
}
