namespace Mischwald.Bats;

public interface IBat : ILeftRight
{
    int IActivePart.GetInstancePoints(PointsCalculationContext ctx)
    {
        var bats = ctx.CurrentPlayer.GetAllCards<IBat>();
        var distinctBats = bats.DistinctBy(b => b.GetType());

        return distinctBats.Count() >= 3 ? 5 : 0;
    }
}
