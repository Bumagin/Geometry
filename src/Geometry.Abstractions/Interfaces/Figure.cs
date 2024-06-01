namespace Geometry.Abstractions.Interfaces;

/// <summary>
/// Представляет абстрактный класс фигуры, от которого должны наследоваться конкретные классы фигур.
/// </summary>
public abstract class Figure : IAreaCalculatable
{
    /// <summary>
    /// Вычисляет площадь фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    /// <remarks>
    /// Конкретные классы фигур должны переопределить этот метод с использованием специфической логики вычисления площади.
    /// </remarks>
    public abstract double CalculateArea();
}