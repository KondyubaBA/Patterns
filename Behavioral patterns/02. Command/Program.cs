namespace Command;

internal class Program
{
    static void Main()
    {
        var light = new Light();
        ICommand lightOn = new LightOnCommand(light);
        ICommand lightOff = new LightOffCommand(light);

        var remote = new RemoteControl();

        // Включаем свет
        remote.SetCommand(lightOn);
        remote.PressButton(); // Вывод: Свет включен.

        // Выключаем свет
        remote.SetCommand(lightOff);
        remote.PressButton(); // Вывод: Свет выключен.

        // Отмена последней операции (включаем свет снова)
        remote.PressUndo(); // Вывод: Свет включен.
    }
}
