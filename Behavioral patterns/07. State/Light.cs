namespace State;

// Контекст — светильник
public class Light
{
    private ILightState currentState;

    public Light()
    {
        currentState = new OffState(this); // Начальное состояние — выключен
    }

    public void SetState(ILightState state)
    {
        currentState = state;
    }

    public void SwitchOn() => currentState.SwitchOn();
    public void SwitchOff() => currentState.SwitchOff();
}

