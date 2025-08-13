namespace Observer;

public class TVChannel : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("ТВ канал получил новость: " + message);
    }
}
