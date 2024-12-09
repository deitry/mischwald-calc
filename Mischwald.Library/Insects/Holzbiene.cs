using Mischwald.Trees;

namespace Mischwald.Insects;

public class Holzbiene : Insect, ILeftRight
{
    public TreeTypeEnum TreeType => Parent?.TreeType ?? TreeTypeEnum.None;
}
