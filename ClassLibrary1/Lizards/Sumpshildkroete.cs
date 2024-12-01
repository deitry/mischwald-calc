namespace ClassLibrary1.Lizards;

/// <summary>
/// Черепаха
/// </summary>
public class Sumpshildkroete : ILizard
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return 5;
    }
}
