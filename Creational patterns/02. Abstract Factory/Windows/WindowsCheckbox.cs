namespace Abstract_Factory.Windows;

public class WindowsCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Рисуем чекбокс в стиле Windows.");
    }
}
