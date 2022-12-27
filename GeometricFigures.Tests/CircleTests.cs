using GeometricFigures;

namespace GeometricFigures.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Constructor_ThrowsArgumentException_RadiosLessOrEqualZero(double radius)
    {
        // Arrange && Act
        void Act() => new Circle(radius);

        //Assert
        Assert.Throws<ArgumentException>(Act);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void GetRadius_ReturnsExpectedRadius_Equals(double radius)
    {
        // Arrange 
        var circle = new Circle(radius);

        //Act
        var actual = circle.Radius;
        
        //Assert
        Assert.Equal(radius, actual);
    }

    [Theory]
    [InlineData(1, 3.1415926535897931)]
    [InlineData(2, 12.566370614359172)]
    public void GetSquare_ReturnsExpectedSquare_Equals(double radius, double square)
    {
        // Arrange 
        var circle = new Circle(radius);

        //Act
        var actual = circle.GetSquare();

        //Assert
        Assert.Equal(square, actual);
    }
}