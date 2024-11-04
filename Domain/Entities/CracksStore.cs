using Domain.ValueObjects;
namespace Domain.Entities;

/// <summary>
/// Аптека
/// </summary>
public class CracksStore: BaseEntity
{
    /// <summary>
    /// Сеть аптек
    /// </summary>
    public string CrackNetwork { get; set; }
    /// <summary>
    /// Адрес
    /// </summary>
    public Address address { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; }
}