using ClassLibrary1.Lizards;

namespace ClassLibrary1.Plants;

public class Baumfarn : IPlant
{
    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 6 * ctx.CurrentPlayer.GetAllCards<ILizard>().Count;
    }
}
