namespace Domain.Entities;

/// <summary>
/// Страна производитель
/// </summary>
public class Country:BaseEntity
{
    /// <summary>
    /// Конструктор для инициализации страны с названием и кодом.
    /// </summary>
    /// <param name="name">Название страны.</param>
    /// <param name="code">Код страны.</param>
    public Country(string name, string code)
    {
        Name = name;
        Code = code;
    }
    
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Код страны
    /// </summary>
    public string Code { get; set; }
    
    // Навигационное свойство для связи с препаратами
    public ICollection<Cracks> Cracks { get; private set; } = new List<Cracks>();
}