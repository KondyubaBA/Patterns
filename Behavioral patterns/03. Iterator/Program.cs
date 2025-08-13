namespace Iterator;

/// <summary>
/// Паттерн Итератор (Iterator) предоставляет способ последовательного обхода элементов коллекции без раскрытия её внутреннего представления.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        var collection = new MyCollection<string>();
        collection.Add("Первый");
        collection.Add("Второй");
        collection.Add("Третий");

        var iterator = collection.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
