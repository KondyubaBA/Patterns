namespace Abstract_Factory.Windows;

public class WindowsButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Рисуем кнопку в стиле Windows.");
    }
}
