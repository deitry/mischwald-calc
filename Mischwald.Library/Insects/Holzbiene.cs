using Mischwald.Trees;

namespace Mischwald.Insects;

public class Holzbiene : IInsect, ILeftRight
{
    public T_Tree? Parent { get; set; }

    public TreeTypeEnum TreeType => Parent?.TreeType ?? TreeTypeEnum.None;
}
