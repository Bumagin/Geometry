namespace Geometry.Abstractions.Interfaces;

/// <summary>
/// Определяет интерфейс для объектов, которые могут проверять, выполняются ли для них условия прямоугольности.
/// </summary>
public interface IRectangularCheckable
{
    /// <summary>
    /// Выполняет проверку на соответствие условиями прямоугольности.
    /// </summary>
    /// <returns>Возвращает true, если для объекта выполняются условия прямоугольности, иначе false.</returns>
    bool IsRectangle();
}