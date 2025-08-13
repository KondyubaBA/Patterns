namespace Facade;

// Подсистема: Проектор
public class Projector
{
    public void On()
    {
        Console.WriteLine("Проектор включен.");
    }

    public void Off()
    {
        Console.WriteLine("Проектор выключен.");
    }

    public void SetInput(string input)
    {
        Console.WriteLine($"Проектор установлен на вход: {input}.");
    }
}
