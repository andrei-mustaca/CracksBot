namespace Domain.ValueObjects;

/// <summary>
/// Адрес аптеки
/// </summary>
public class Address
{
   /// <summary>
   /// Конструктор
   /// </summary>
   /// <param name="city">Город</param>
   /// <param name="street">Улица</param>
   /// <param name="house">Дом</param>
   public Address(string city, string street,string house)
   {
      City = city;
      Street=street;
      House=house;
   }
   /// <summary>
   /// Город
   /// </summary>
   public string City { get; set; }
   /// <summary>
   /// Улица
   /// </summary>
   public string Street { get; set; }
   /// <summary>
   /// Дом
   /// </summary>
   public string House { get; set; }
   
   /// <summary>
   /// Возвращает строковое представление адреса.
   /// </summary>
   /// <returns>Строка, представляющая адрес.</returns>
   public override string ToString()
   {
      return $"{City}, {Street}, {House}";
   }
}