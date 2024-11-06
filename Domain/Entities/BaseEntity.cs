namespace Domain.Entities;

/// <summary>
/// TODO:Коменты
/// Абстрактный класс
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Конструктор по умолчанию, инициализирующий новый уникальный идентификатор.
    /// </summary>
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
    
    /// <summary>
    /// Переопределение метода Equals для сравнения сущностей по идентификатору.
    /// </summary>
    /// <param name="obj">Объект для сравнения.</param>
    /// <returns>True, если идентификаторы совпадают; иначе False.</returns>
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj))
            return true;

        if (obj is null || obj.GetType() != GetType())
            return false;

        var other = (BaseEntity)obj;
        return Id.Equals(other.Id);
    }

    /// <summary>
    /// Метод для вычисления хэш кода объекта
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    /// <summary>
    /// Переопределение оператор ==
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(BaseEntity? left, BaseEntity? right)
    {
        if (left is null)
            return right is null;

        return left.Equals(right);
    }

    //TODO: переопределить операторы == и !=
    /// <summary>
    /// Переопределение оператора !=
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(BaseEntity? left, BaseEntity? right)
    {
        return !(left == right);
    }
}