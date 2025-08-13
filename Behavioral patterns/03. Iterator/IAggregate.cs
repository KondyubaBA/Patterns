namespace Iterator;

/// <summary>
/// Интерфейс коллекции
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
