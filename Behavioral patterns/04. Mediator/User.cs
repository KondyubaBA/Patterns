namespace Mediator;

/// <summary>
/// Участники (коллеги)
/// </summary>
public class User : Participant
{
    private readonly string _name;

    public User(string name)
    {
        _name = name;
    }

    public override void Send(string message)
    {
        Console.WriteLine($"{_name} отправляет сообщение: {message}");
        Mediator.Notify(this, message);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{_name} получил сообщение: {message}");
    }
}
