namespace Mischwald;

public record PointsCalculationContext : GameContext
{
    public required Player CurrentPlayer { get; init; }

    public IReadOnlyList<Player> OtherPlayers => Players.Except([CurrentPlayer]).ToList();

    public bool HasMostOfTrees => OtherPlayers.All(p => p.Trees.Count < CurrentPlayer.Trees.Count);
}
