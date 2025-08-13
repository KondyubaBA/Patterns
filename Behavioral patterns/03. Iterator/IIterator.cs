namespace Iterator;

/// <summary>
/// Интерфейс итератора
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
