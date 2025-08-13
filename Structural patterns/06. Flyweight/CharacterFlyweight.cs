namespace Flyweight;

// Легковес — общий объект, который хранит внутреннее состояние (символ)
public class CharacterFlyweight
{
    private readonly char symbol;

    public CharacterFlyweight(char symbol)
    {
        this.symbol = symbol;
    }

    // Метод рисования с учётом внешнего состояния
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Рисуем символ '{symbol}' в позиции ({x}, {y})");
    }
}
