using System.Reflection;

namespace Mischwald;

public class IntermediateSetResult
{
    private readonly Type _type;

    public static IntermediateSetResult From<T>(PointsCalculationContext ctx)
        where T: ITypePoints
    {
        return new IntermediateSetResult(typeof(T), ctx);
    }

    private IntermediateSetResult(Type type, PointsCalculationContext ctx)
    {
        _type = type;

        CardsCount = ctx.CurrentPlayer.GetAllCards(type).Count;

        if (_type.IsAssignableTo(typeof(ITypePoints)))
        {
            var getTypePointsMethod = _type.GetMethod(nameof(ITypePoints.GetTypePoints),
                BindingFlags.Static | BindingFlags.Public);

            TotalSetPoints = (getTypePointsMethod?.Invoke(null, [ctx]) as int?)
                ?? throw new NullReferenceException("GetTypePoints method returned null");
        }
    }

    public int TotalSetPoints { get; set; }

    public string SetName => _type.Name;

    public int CardsCount { get; }

    public override string ToString()
    {
        if (CardsCount == 0)
            return $"{SetName} : None";

        return $"{SetName} : {TotalSetPoints}";
    }
}
