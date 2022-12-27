namespace GeometricFigures
{
    /// <summary>
    /// Представляет абстракцию поставщика площади геометрической фигуры.
    /// </summary>
    public interface ISquareProvider
    {
        /// <summary>
        /// Получает площадь геометрической фигуры.
        /// </summary>
        /// <param name="figure">Геометрическая фигура.</param>
        /// <returns>Возвращает площадь геометрической фигуры</returns>
        double GetSquare(IFigure figure);
    }

    /// <summary>
    /// Представляет реализацию поставщика площади геометрической фигуры.
    /// </summary>
    public class SquareProvider : ISquareProvider
    {
        /// <inheritdoc />
        public double GetSquare(IFigure figure) => figure.GetSquare();
    }
}