namespace Mischwald;

public record GameContext
{
    public List<Player> Players { get; init; } = new();

    public int GetPoints(Player player)
    {
        return player.GetPoints(new PointsCalculationContext
        {
            CurrentPlayer = player,
        });
    }

    public static int CalculatePoints(Player player)
    {
        var ctx = new GameContext
        {
            Players = [
                player
            ],
        };

        return ctx.GetPoints(player);
    }
}
