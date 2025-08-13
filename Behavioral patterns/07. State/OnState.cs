namespace State;

// Состояние: включен
public class OnState : ILightState
{
    private Light light;

    public OnState(Light light)
    {
        this.light = light;
    }

    public void SwitchOn()
    {
        Console.WriteLine("Светильник уже включен.");
    }

    public void SwitchOff()
    {
        Console.WriteLine("Светильник выключен.");
        light.SetState(new OffState(light)); // Переключение на состояние "выключен"
    }
}
