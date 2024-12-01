namespace ClassLibrary1.AnimalsAndPlants;

public class Feldhase(int count = 1) : IAnimal
{
    public T_Tree? Parent { get; set; }

    public List<IAnimalOrPlant> UnderlyingCards => Enumerable.Repeat<IAnimalOrPlant>(this, Count).ToList();

    public int Count { get; init; } = count;

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
