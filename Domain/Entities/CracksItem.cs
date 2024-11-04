namespace Domain.Entities;

public class CracksItem:BaseEntity
{
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
}