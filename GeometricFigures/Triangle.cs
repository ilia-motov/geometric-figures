using System;
using System.Reflection.Metadata;

namespace GeometricFigures
{
    /// <summary>
    /// Представляет реализацию треугольника.
    /// </summary>
    public class Triangle : ITriangle
    {
        private double _perimetr;

        /// <summary>
        /// Создает новый экземпляр <see cref="Triangle"/>.
        /// </summary>
        /// <param name="sideA">Сторона А.</param>
        /// <param name="sideB">Сторона В.</param>
        /// <param name="sideC">Сторона С.</param>
        /// <exception cref="ArgumentException">Выбрасывает исключение в случае неверно заданных сторон треугольника.</exception>
        public Triangle(double sideA , double sideB, double sideC)
        {
            ValidateSides();
            ValidateMaxSide();

            _perimetr = sideA + sideB + sideC;

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            RightTriangle = CheckRightTriangle();

            void ValidateSides()
            {
                if (sideA <= 0)
                    throw new ArgumentException("Сторона треугольника меньше или равна 0", nameof(sideA));

                if (sideB <= 0)
                    throw new ArgumentException("Сторона треугольника меньше или равна 0", nameof(sideB));

                if (sideC <= 0)
                    throw new ArgumentException("Сторона треугольника меньше или равна 0", nameof(sideC));
            }

            void ValidateMaxSide()
            {
                var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
                var perimetr = sideA + sideB + sideC;

                if (perimetr - maxSide - maxSide <= 0)
                    throw new ArgumentException("Одна из сторон треугольника больше или равна суммы двух других");
            }
        }

        /// <inheritdoc />
        public double SideA { get; }

        /// <inheritdoc />
        public double SideB { get; }

        /// <inheritdoc />
        public double SideC { get; }

        /// <inheritdoc />
        public bool RightTriangle { get; set; } = false;

        /// <summary>
        /// Рассчитывает площадь треугольника, используя формулу по трём сторонам через полупериметр.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double GetSquare()
        {
            double semiPerimeter = _perimetr / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        private bool CheckRightTriangle()
        {
            double maxSide = SideA;
            double sideB = SideB;
            double sideC = SideC;

            if (sideB - maxSide > 0)
                (maxSide, sideB) = (sideB, maxSide);

            if (sideC - maxSide > 0)
                (maxSide, sideC) = (sideC, maxSide);

            return Math.Abs(Math.Pow(maxSide, 2) - Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) == 0;
        }
    }
}