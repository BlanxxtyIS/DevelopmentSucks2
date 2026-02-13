namespace DevelopmentSucks2.Domain.Repositories.Auth;

/// <summary>
/// Интерфейс для работы с хэшированием паролей.
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// Выполняет хэширование указанного пароля.
    /// </summary>
    /// <param name="password">Обычный (нехэшированный) пароль.</param>
    /// <returns>Захешированный пароль.</returns>
    public string Hash(string password);

    /// <summary>
    /// Проверяет соответствие пароля его хэшу.
    /// </summary>
    /// <param name="hash">Ранее захэшированный пароль.</param>
    /// <param name="password">Обычный (нехэшированный) пароль для проверки.</param>
    /// <returns><c>true</c>, если пароль соответствует хэшу; иначе <c>false</c>.</returns>
    public bool Verify(string hash, string password);
}
