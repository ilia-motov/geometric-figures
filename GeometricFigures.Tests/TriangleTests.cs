using GeometricFigures;

namespace GeometricFigures.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1, 0, 0, "sideA")]
        [InlineData(0, 0, 0, "sideA")]
        [InlineData(1, -1, 0, "sideB")]
        [InlineData(1, 0, 0, "sideB")]
        [InlineData(1, 1, -1, "sideC")]
        [InlineData(1, 1, 0, "sideC")]
        public void Constructor_ThrowsArgumentException_SideLessOrEqualZero(
            double sideA,
            double sideB,
            double sideC,
            string paramName)
        {
            // Arrange && Act
            void Act() => new Triangle(sideA, sideB, sideC);

            //Assert
            Assert.Throws<ArgumentException>(paramName, Act);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        public void Constructor_ThrowsArgumentException_MaxSideGreaterOrEqualSumOtherTwo(
            double sideA,
            double sideB,
            double sideC)
        {
            // Arrange && Act
            void Act() => new Triangle(sideA, sideB, sideC);

            //Assert
            Assert.Throws<ArgumentException>(Act);
        }

        [Fact]
        public void GetSideA_ReturnsExpectedRadius_Equals()
        {
            // Arrange 
            double expectedSideA = 1;

            var triangle = new Triangle(expectedSideA, 2, 2);

            //Act
            var actual = triangle.SideA;
            
            //Assert
            Assert.Equal(expectedSideA, actual);
        }

        [Fact]
        public void GetSideB_ReturnsExpectedRadius_Equals()
        {
            // Arrange 
            double expectedSideB = 2;

            var triangle = new Triangle(1, expectedSideB, 2);

            //Act
            var actual = triangle.SideB;
            
            //Assert
            Assert.Equal(expectedSideB, actual);
        }

        [Fact]
        public void GetSideC_ReturnsExpectedRadius_Equals()
        {
            // Arrange 
            double expectedSideC = 2;

            var triangle = new Triangle(1, 2, expectedSideC);

            //Act
            var actual = triangle.SideC;
            
            //Assert
            Assert.Equal(expectedSideC, actual);
        }

        [Fact]
        public void GetRightTriangle_ReturnsTrue()
        {
            // Arrange 
            var triangle = new Triangle(3, 4, 5);

            //Act
            var actual = triangle.RightTriangle;
            
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void GetRightTriangle_ReturnsFalse()
        {
            // Arrange 
            var triangle = new Triangle(1, 2, 2);

            //Act
            var actual = triangle.RightTriangle;
            
            //Assert
            Assert.False(actual);
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
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actual = triangle.GetSquare();

            //Assert
            Assert.Equal(square, actual);
        }
    }
}
