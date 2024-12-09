using System.Diagnostics;
using Mischwald.Trees;

namespace Mischwald.Lizards;

public class Erdkroete : ILizard
{
    public ErdkroeteStack? ParentStack { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ParentStack?.IsFull == true ? 5 : 0;
    }
}
