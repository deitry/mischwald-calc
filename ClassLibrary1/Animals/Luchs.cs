using ClassLibrary1.Paarhufer.Hirsch;

namespace ClassLibrary1.AnimalsAndPlants;

public class Luchs : IAnimal
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var hasReh = ctx.CurrentPlayer.GetAllCards<Reh>().Count > 0;

        return hasReh ? 10 : 0;
    }
}
