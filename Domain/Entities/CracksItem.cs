namespace Domain.Entities;

public class CracksItem:BaseEntity
{
    public CracksItem(Guid drugId, Guid drugStoreId, decimal cost, int count, Cracks crack, CracksStore crackStore)
    {
        CrackId = drugId;
        CrackStoreId = drugStoreId;
        Cost = cost;
        Count = count;
        Crack = crack;
        CrackStore = crackStore;
    }
    
    /// <summary>
    /// Идентификатор лекарства
    /// </summary>
    public Guid CrackId { get; set; }
    /// <summary>
    /// Идентификатор аптеки
    /// </summary>
    public Guid CrackStoreId { get; set; }
    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Cost { get; set; }
    /// <summary>
    /// Количество
    /// </summary>
    public int Count { get; set; }
    
    // Навигационные свойства
    public Cracks Crack { get; private set; }
    public CracksStore CrackStore { get; private set; }
}