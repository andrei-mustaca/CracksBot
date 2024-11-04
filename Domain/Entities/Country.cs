namespace Domain.Entities;

/// <summary>
/// Страна производитель
/// </summary>
public class Country:BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Код страны
    /// </summary>
    public string Code { get; set; }
}