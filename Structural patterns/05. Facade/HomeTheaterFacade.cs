namespace Facade;

public class HomeTheaterFacade
{
    private Projector projector;
    private Screen screen;
    private Amplifier amplifier;

    public HomeTheaterFacade(Projector projector, Screen screen, Amplifier amplifier)
    {
        this.projector = projector;
        this.screen = screen;
        this.amplifier = amplifier;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Подготовка к просмотру фильма...");
        screen.Down();
        projector.On();
        projector.SetInput("HDMI");
        amplifier.On();
        amplifier.SetVolume(5);
        Console.WriteLine("Фильм запущен!");
    }

    public void EndMovie()
    {
        Console.WriteLine("Завершение просмотра фильма...");
        projector.Off();
        screen.Up();
        amplifier.Off();
        Console.WriteLine("Просмотр завершён.");
    }
}
