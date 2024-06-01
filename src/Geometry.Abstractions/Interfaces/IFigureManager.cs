namespace Geometry.Abstractions.Interfaces;

/// <summary>
/// Интерфейс IFigureManager предоставляет методы для работы с геометрическими фигурами.
/// </summary>
public interface IFigureManager
{
    /// <summary>
    /// Возвращает площадь заданной фигуры.
    /// </summary>
    /// <param name="figure">Фигура, площадь которой необходимо вычислить.</param>
    /// <returns>Площадь фигуры.</returns>
    double GetArea(Figure figure);

    /// <summary>
    /// Выполняет проверку на соответствие условиям прямоугольности.
    /// Принимает экземпляры классов, реализующих интерфейс IRectangularCheckable.
    /// </summary>
    /// <param name="figure">Фигура, которую необходимо проверить на прямоугольность.</param>
    /// <returns>Возвращает значение true, если фигура является прямоугольным треугольником, иначе false.</returns>
    bool IsRectangular(IRectangularCheckable figure);
}