using Geometry.Abstractions.Exceptions;
using Geometry.Abstractions.Interfaces;

namespace Geometry.Domain;

public class Triangle : Figure, IRectangularCheckable
{
    private readonly double _leftSide;
    private readonly double _rightSide;
    private readonly double _downSide;

    public Triangle(double leftSide, double rightSide, double downSide)
    {
        if (leftSide <= 0 || rightSide <= 0 || downSide <= 0)
            throw new InvalidFigureException("Sides must be greater than zero");

        if (leftSide + rightSide <= downSide || leftSide + downSide <= rightSide || rightSide + downSide <= leftSide)
            throw new InvalidFigureException("The given sides do not form a triangle");

        _leftSide = leftSide;
        _rightSide = rightSide;
        _downSide = downSide;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = (_leftSide + _rightSide + _downSide) / 2;
        return Math.Sqrt(
            semiPerimeter * (semiPerimeter - _leftSide) * (semiPerimeter - _rightSide) * (semiPerimeter - _downSide)
        );
    }

    public bool IsRectangle()
    {
        var sides = new[] { _leftSide, _rightSide, _downSide };
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 0.001;
    }
}