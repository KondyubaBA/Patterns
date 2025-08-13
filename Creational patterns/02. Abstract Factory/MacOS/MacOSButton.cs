namespace Abstract_Factory.MacOS;

public class MacOSButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Рисуем кнопку в стиле MacOS.");
    }
}
