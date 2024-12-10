using System.Diagnostics;
using Mischwald.Trees;

namespace Mischwald.Lizards;

/// <summary>
/// Can be assigned to a tree only as a part of <see cref="ErdkroeteStack"/>
/// </summary>
public class Erdkroete : Lizard, ICardName
{
    public ErdkroeteStack? ParentStack { get; set; }

    public override int GetInstancePoints(PointsCalculationContext ctx)
    {
        return ParentStack?.IsFull == true ? 5 : 0;
    }
}
