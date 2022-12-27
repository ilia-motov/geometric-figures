namespace GeometricFigures;

/// <summary>
/// Представляет абстракцию круга.
/// </summary>
public interface ICircle : IFigure
{
    /// <summary>
    /// Получает радиус круга.
    /// </summary>
    public double Radius { get; }
}
