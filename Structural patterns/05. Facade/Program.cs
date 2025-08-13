namespace Facade;

/// <summary>
/// Паттерн Фасад (Facade) предоставляет упрощённый интерфейс к сложной системе классов, библиотек или фреймворков. 
/// Он скрывает сложность и предоставляет более простой интерфейс для использования.
/// </summary>
class Program
{
    static void Main()
    {
        // Создание компонентов
        var projector = new Projector();
        var screen = new Screen();
        var amplifier = new Amplifier();

        // Создание фасада
        var homeTheater = new HomeTheaterFacade(projector, screen, amplifier);

        // Использование фасада для просмотра фильма
        homeTheater.WatchMovie();

        // Завершение просмотра фильма
        homeTheater.EndMovie();
    }
}
