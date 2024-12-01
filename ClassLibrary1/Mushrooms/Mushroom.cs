namespace ClassLibrary1.Mushrooms;

public class Mushroom : IActivePart, IBottom
{
    public T_Tree? Parent { get; set; }
}
