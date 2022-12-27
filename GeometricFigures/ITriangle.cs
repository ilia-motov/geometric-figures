namespace GeometricFigures
{
    /// <summary>
    /// Представляет абстракцию треугольника.
    /// </summary>
    public interface ITriangle : IFigure
    {
        /// <summary>
        /// Получает сторону А.
        /// </summary>
        double SideA { get; }

        /// <summary>
        /// Получает сторону B.
        /// </summary>
        double SideB { get; }

        /// <summary>
        /// Получает сторону С.
        /// </summary>
        double SideC { get; }

        /// <summary>
        /// Получает флаг, указывающий, что треугольник является прямоугольным.
        /// </summary>
        bool RightTriangle { get; }
    }
}