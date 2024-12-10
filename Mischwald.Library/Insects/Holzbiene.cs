using Mischwald.Trees;

namespace Mischwald.Insects;

public class Holzbiene : Insect, ILeftRight, ICardName
{
    public override TreeTypeEnum TreeType => Parent?.TreeType ?? TreeTypeEnum.None;
}
