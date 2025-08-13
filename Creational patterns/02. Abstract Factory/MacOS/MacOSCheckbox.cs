namespace Abstract_Factory.MacOS;

public class MacOSCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Рисуем чекбокс в стиле MacOS.");
    }
}
