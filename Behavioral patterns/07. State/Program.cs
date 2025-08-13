namespace State;

class Program
{
    static void Main()
    {
        var light = new Light();

        light.SwitchOn(); // Включаем светильник
        light.SwitchOn(); // Пытаемся снова включить
        light.SwitchOff(); // Выключаем светильник
        light.SwitchOff(); // Пытаемся снова выключить
    }
}
