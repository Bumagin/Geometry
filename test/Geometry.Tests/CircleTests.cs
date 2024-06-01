using Geometry.Abstractions.Exceptions;
using Geometry.Domain;

namespace Geometry.Tests;

public class CircleTests
{
    [Fact]
    public void Constructor_ShouldThrowInvalidFigureException_ForNonPositiveRadius()
    {
        Assert.Throws<InvalidFigureException>(() => new Circle(0));
        Assert.Throws<InvalidFigureException>(() => new Circle(-1));
    }

    [Fact]
    public void CalculateArea_ShouldReturnCorrectValue()
    {
        var radius = 5.0;
        var circle = new Circle(radius);
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        var actualArea = circle.CalculateArea();

        Assert.Equal(expectedArea, actualArea);
    }
}