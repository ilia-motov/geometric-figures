namespace GeometricFigures
{
    /// <summary>
    /// Представляет реализацию круга.
    /// </summary>
    public class Circle : ICircle
    {
        /// <summary>
        /// Создает новый экземпляр <see cref="Circle"/>.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключение в случае неверного радиуса.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно задан радиус круга.", nameof(radius));

            Radius = radius;
        }

        /// <inheritdoc />
        public double Radius { get; }

        /// <summary>
        /// Расчитывает площадь круга используя формулу по радиусу.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double GetSquare() => Math.PI * Radius * Radius;
    }
}