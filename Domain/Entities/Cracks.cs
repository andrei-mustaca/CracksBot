namespace Domain.Entities;

/// <summary>
/// Лекарственный преппарат
/// </summary>
public class Cracks:BaseEntity
{
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Производитель
    /// </summary>
    public string Manufacter { get; set; }
    /// <summary>
    /// Идентификатор кода страны
    /// </summary>
    public string CountryCodeId { get; set; }
}