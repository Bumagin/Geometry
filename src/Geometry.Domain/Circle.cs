using Geometry.Abstractions.Exceptions;
using Geometry.Abstractions.Interfaces;

namespace Geometry.Domain;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new InvalidFigureException("Radius should be greater than zero");

        _radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}