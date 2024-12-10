using Mischwald.Trees;

namespace Mischwald.Insects;

public class Gluewuermchen : Insect, IBottom, ITypePoints
{
    public static int GetTypePoints(PointsCalculationContext ctx)
    {
        var total = ctx.CurrentPlayer.GetAllCards<Gluewuermchen>().Count;
        return total switch
        {
            1 => 0,
            2 => 10,
            3 => 15,
            >= 4 => 20,
            _ => 0,
        };
    }
}
