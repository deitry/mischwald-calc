using ClassLibrary1.Butterflies;

namespace ClassLibrary1.AnimalsAndPlants;

public class Igel : IBottom, IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        var butterflies = ctx.CurrentPlayer.GetAllCards<Butterfly>();
        return 2 * butterflies.Count;
    }
}
