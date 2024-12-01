using ClassLibrary1.AnimalsAndPlants;

namespace ClassLibrary1.Bats;

public interface IBat : IAnimalOrPlant
{
    int IActivePart.GetInstancePoints(PointsCalculationContext ctx)
    {
        var bats = ctx.CurrentPlayer.GetAllCards<IBat>();
        var distinctBats = bats.DistinctBy(b => b.GetType());

        return distinctBats.Count() >= 3 ? 5 : 0;
    }
}
