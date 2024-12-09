namespace Mischwald.Bats;

public abstract class Bat : AnimalOrPlant, ILeftRight
{
    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        var bats = ctx.CurrentPlayer.GetAllCards<Bat>();
        var distinctBats = bats.DistinctBy(b => b.GetType());

        return distinctBats.Count() >= 3 ? 5 : 0;
    }
}
