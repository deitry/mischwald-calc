using Mischwald.Trees;

namespace Mischwald.Animals;

public class Siebenschlaefer : IAnimal
{
    public T_Tree? Parent { get; set; }

    public int GetInstancePoints(PointsCalculationContext ctx)
    {
        throw new NotImplementedException();

        // 15 очков если с другой стороны дерева есть летучая мышь

        // TODO: разделять на правую и левую?
        // TODO: использовать отдельную проперти Parent или искать каждый раз?
    }
}
