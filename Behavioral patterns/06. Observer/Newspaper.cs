namespace Observer;

public class Newspaper : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("Газета получила новость: " + message);
    }
}
