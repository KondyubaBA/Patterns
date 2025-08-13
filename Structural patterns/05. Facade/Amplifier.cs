namespace Facade;

// Подсистема: Усилитель
public class Amplifier
{
    public void On()
    {
        Console.WriteLine("Усилитель включен.");
    }

    public void Off()
    {
        Console.WriteLine("Усилитель выключен.");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Усилитель установлен на уровень громкости: {level}.");
    }
}
