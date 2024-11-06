namespace Domain.Entities;

/// <summary>
/// Лекарственный преппарат
/// </summary>
public class Cracks:BaseEntity
{
    /// <summary>
    /// Конструктор класса Cracks
    /// </summary>
    /// <param name="name">Название преппарата</param>
    /// <param name="manufacturer">Производитель</param>
    /// <param name="countryCodeId">Код страны производителя</param>
    /// <param name="country"></param>
    public Cracks(string name, string manufacturer, string countryCodeId, Country country)
    {
        Name = name;
        Manufacter = manufacturer;
        CountryCodeId = countryCodeId;
        Country = country;
    }
    
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
    
    // Навигационное свойство для связи с объектом Country
    public Country Country { get; private set; }
        
    // Навигационное свойство для связи с DrugItem
    public ICollection<CracksItem> DrugItems { get; private set; } = new List<CracksItem>();
}