using Geometry.Abstractions.Exceptions;
using Geometry.Domain;

namespace Geometry.Tests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ShouldThrowInvalidFigureException_ForNonPositiveSides()
    {
        Assert.Throws<InvalidFigureException>(() => new Triangle(0, 1, 1));
        Assert.Throws<InvalidFigureException>(() => new Triangle(-1, 1, 1));
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, 0, 1));
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, -1, 1));
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, 1, 0));
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, 1, -1));
    }

    [Fact]
    public void Constructor_ShouldThrowInvalidFigureException_ForInvalidTriangleInequality()
    {
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, 1, 3));
        Assert.Throws<InvalidFigureException>(() => new Triangle(1, 3, 1));
        Assert.Throws<InvalidFigureException>(() => new Triangle(3, 1, 1));
    }

    [Fact]
    public void CalculateArea_ShouldReturnCorrectValue()
    {
        var leftSide = 3.0;
        var rightSide = 4.0;
        var downSide = 5.0;
        var triangle = new Triangle(leftSide, rightSide, downSide);
        var semiPerimeter = (leftSide + rightSide + downSide) / 2;
        var expectedArea = Math.Sqrt(
            semiPerimeter * (semiPerimeter - leftSide) * (semiPerimeter - rightSide) * (semiPerimeter - downSide)
        );

        var actualArea = triangle.CalculateArea();

        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void IsRectangle_ShouldReturnTrue_ForRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRectangle = triangle.IsRectangle();

        Assert.True(isRectangle);
    }

    [Fact]
    public void IsRectangle_ShouldReturnFalse_ForNonRightTriangle()
    {
        var triangle = new Triangle(3, 4, 6);

        var isRectangle = triangle.IsRectangle();

        Assert.False(isRectangle);
    }
}