namespace State;

// Состояние: выключен
public class OffState : ILightState
{
    private Light light;

    public OffState(Light light)
    {
        this.light = light;
    }

    public void SwitchOn()
    {
        Console.WriteLine("Светильник включен.");
        light.SetState(new OnState(light)); // Переключение на состояние "включен"
    }

    public void SwitchOff()
    {
        Console.WriteLine("Светильник уже выключен.");
    }
}
