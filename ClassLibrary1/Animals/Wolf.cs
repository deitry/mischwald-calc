using ClassLibrary1.Paarhufer.Hirsch;

namespace ClassLibrary1.AnimalsAndPlants;

public sealed class Wolf : IAnimal
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hirschen = ctx.CurrentPlayer.GetAllCards<Hirsch>();

        return 5 * hirschen.Count;
    }
}
