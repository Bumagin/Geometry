namespace Geometry.Abstractions.Interfaces;

/// <summary>
/// Определяет интерфейс для объектов, которые могут вычислять свою площадь.
/// </summary>
public interface IAreaCalculatable
{
    /// <summary>
    /// Вычисляет и возвращает площадь объекта.
    /// </summary>
    /// <returns>Площадь объекта.</returns>
    double CalculateArea();
}