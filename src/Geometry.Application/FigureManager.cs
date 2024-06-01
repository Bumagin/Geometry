using Geometry.Abstractions.Interfaces;

namespace Geometry.Application;

public class FigureManager : IFigureManager
{
    public double GetArea(Figure figure)
    {
        return figure.CalculateArea();
    }

    public bool IsRectangular(IRectangularCheckable figure)
    {
        return figure.IsRectangle();
    }
}