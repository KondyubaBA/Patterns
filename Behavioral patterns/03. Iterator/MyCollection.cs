namespace Iterator;

/// <summary>
/// Конкретная коллекция
/// </summary>
/// <typeparam name="T"></typeparam>
public class MyCollection<T> : IAggregate<T>
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new MyIterator<T>(this);
    }

    public int Count => _items.Count;

    public T this[int index] => _items[index];

    private class MyIterator<U> : IIterator<U>
    {
        private readonly MyCollection<U> _collection;
        private int _current = 0;

        public MyIterator(MyCollection<U> collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return _current < _collection.Count;
        }

        public U Next()
        {
            return _collection[_current++];
        }
    }
}