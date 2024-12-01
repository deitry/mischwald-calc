using System.Diagnostics;
using Mischwald.Trees;

namespace Mischwald.Lizards;

public class Erdkroete : ILizard
{
    public T_Tree? Parent { get; set; }

    public ErdkroeteStack? ParentStack { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ParentStack?.IsFull == true ? 5 : 0;
    }
}
