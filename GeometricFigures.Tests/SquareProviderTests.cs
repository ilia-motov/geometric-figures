using GeometricFigures;

namespace GeometricFigures.Tests
{
    public class SquareProviderTests
    {
        [Theory]
        [InlineData(1, 3.1415926535897931)]
        [InlineData(2, 12.566370614359172)]
        public void GetSquare_ReturnsExpectedSquare_Equal(double radius, double square)
        {
            // Arrange 
            var provider = new SquareProvider();
            var circle = new Circle(radius);

            //Act
            var actual = provider.GetSquare(circle);

            //Assert
            Assert.Equal(square, actual);
        }

        [Theory]
        [InlineData(1, 2, 2, 0.96824583655185426)]
        [InlineData(3, 4, 5, 6)]
        public void GetSquare_ReturnsExpectedSquare_Equals(
            double sideA,
            double sideB,
            double sideC,
            double square)
        {
            // Arrange
            var provider = new SquareProvider();
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actual = provider.GetSquare(triangle);

            //Assert
            Assert.Equal(square, actual);
        }
    }
}
