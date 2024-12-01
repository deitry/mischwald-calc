namespace ClassLibrary1.AnimalsAndPlants;

/// <summary>
/// Лиса
/// </summary>
public class Fuchs : IAnimal
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 2 * ctx.CurrentPlayer.GetAllCards<Feldhase>().Count;
    }

    public int GetTypePoints(PointsCalculationContext ctx) => 0;
}
