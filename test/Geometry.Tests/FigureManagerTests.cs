using Geometry.Application;
using Geometry.Domain;

namespace Geometry.Tests;

public class FigureManagerTests
{
    [Fact]
    public void GetArea_ShouldReturnCorrectArea_ForCircle()
    {
        var radius = 5.0;
        var circle = new Circle(radius);
        var figureManager = new FigureManager();
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        var actualArea
            = figureManager.GetArea(circle);

        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void GetArea_ShouldReturnCorrectArea_ForTriangle()
    {
        var leftSide = 3.0;
        var rightSide = 4.0;
        var downSide = 5.0;
        var triangle = new Triangle(leftSide, rightSide, downSide);
        var figureManager = new FigureManager();
        var semiPerimeter = (leftSide + rightSide + downSide) / 2;
        var expectedArea = Math.Sqrt(
            semiPerimeter * (semiPerimeter - leftSide) * (semiPerimeter - rightSide) * (semiPerimeter - downSide)
        );

        var actualArea = figureManager.GetArea(triangle);

        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void IsRectangular_ShouldReturnTrue_ForRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        var figureManager = new FigureManager();

        var isRectangular = figureManager.IsRectangular(triangle);

        Assert.True(isRectangular);
    }

    [Fact]
    public void IsRectangular_ShouldReturnFalse_ForNonRightTriangle()
    {
        var triangle = new Triangle(3, 4, 6);
        var figureManager = new FigureManager();

        var isRectangular = figureManager.IsRectangular(triangle);

        Assert.False(isRectangular);
    }
}