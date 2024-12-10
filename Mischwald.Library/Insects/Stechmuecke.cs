using Mischwald.Bats;
using Mischwald.Trees;

namespace Mischwald.Insects;

// ReSharper disable once ClassNeverInstantiated.Global
public class Stechmuecke : Insect, ILeftRight, ICardName
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 1 * ctx.CurrentPlayer.GetAllCards<Bat>().Count;
    }
}
