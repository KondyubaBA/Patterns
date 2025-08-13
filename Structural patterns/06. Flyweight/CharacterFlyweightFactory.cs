namespace Flyweight;

// Фабрика для создания и хранения легковесов
public class CharacterFlyweightFactory
{
    private readonly Dictionary<char, CharacterFlyweight> flyweights = [];

    public CharacterFlyweight GetFlyweight(char symbol)
    {
        if (!flyweights.ContainsKey(symbol))
        {
            flyweights[symbol] = new CharacterFlyweight(symbol);
            Console.WriteLine($"Создан новый легковес для символа '{symbol}'");
        }
        else
        {
            Console.WriteLine($"Используем существующий легковес для символа '{symbol}'");
        }
        return flyweights[symbol];
    }
}
