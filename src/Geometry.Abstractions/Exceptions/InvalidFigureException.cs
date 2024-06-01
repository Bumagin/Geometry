namespace Geometry.Abstractions.Exceptions;

/// <summary>
/// Представляет ошибки, которые происходят при работе с недействительной фигурой.
/// </summary>
public class InvalidFigureException : Exception
{
    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="InvalidFigureException"/>.
    /// </summary>
    public InvalidFigureException()
    {
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="InvalidFigureException"/> с указанным сообщением об ошибке.
    /// </summary>
    /// <param name="message">сообщение, которое описывает ошибку.</param>
    public InvalidFigureException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="InvalidFigureException"/> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, 
    /// являющееся причиной данного исключения.
    /// </summary>
    /// <param name="message">Сообщение, которое описывает ошибку.</param>
    /// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр inner не представляет допустимое исключение, 
    /// на внутреннее исключение можно не ссылаться.</param>
    public InvalidFigureException(string message, Exception inner)
        : base(message, inner)
    {
    }
}