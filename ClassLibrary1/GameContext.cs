namespace ClassLibrary1;

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
}
