namespace Command;

/// <summary>
/// Получатель (Receiver)
/// </summary>
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Свет включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Свет выключен.");
    }
}
