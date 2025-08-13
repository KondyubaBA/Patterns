namespace Observer;

public class NewsAgency : ISubject
{
    private readonly List<IObserver> _observers = [];
    private string _news;

    public string News
    {
        get => _news;
        set
        {
            _news = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_news);
        }
    }
}
