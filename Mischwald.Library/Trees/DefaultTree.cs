namespace Mischwald.Trees;

/// <summary>
/// "Дерево", полученное выкладыванием любой карт рубашкой вверх
/// </summary>
public class DefaultTree: T_Tree, ICardName
{
    public override TreeTypeEnum TreeType => TreeTypeEnum.None;
}
