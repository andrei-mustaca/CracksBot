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
    /// Метод для сравнения
    /// </summary>
    /// <param name="obj"> параметр принимаемый методом</param>
    /// <returns></returns>
    protected bool Equals(object obj)
    {
        //TODO: сравнение по id
        //Проверка на null
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        //Приведение к типу класса
        var other = (BaseEntity)obj;
        return this.Id == other.Id;
        
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
    public static bool operator ==(BaseEntity left, BaseEntity right)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }
        return left.Id == right.Id;
    }

    //TODO: переопределить операторы == и !=
    /// <summary>
    /// Переопределение оператора !=
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(BaseEntity left, BaseEntity right)
    {
        return !(left == right);
    }
}