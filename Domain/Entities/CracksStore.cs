using Domain.ValueObjects;
namespace Domain.Entities;

/// <summary>
/// Аптека
/// </summary>
public class CracksStore: BaseEntity
{
    public CracksStore(string drugNetwork, int number, Address address)
    {
        CrackNetwork = drugNetwork;
        PhoneNumber = number;
        Address = address;
    }
    
    /// <summary>
    /// Сеть аптек
    /// </summary>
    public string CrackNetwork { get; set; }
    /// <summary>
    /// Адрес
    /// </summary>
    public Address Address { get; set; }
    /// <summary>
    /// Номер телефона
    /// </summary>
    public int PhoneNumber { get; set; }
    
    // Навигационное свойство для связи с DrugItem
    public ICollection<CracksItem> CracksItems { get; private set; } = new List<CracksItem>();
}