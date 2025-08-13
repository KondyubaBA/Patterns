namespace Flyweight;

internal class Program
{
    static void Main()
    {
        string document = "ABACAB";
        var factory = new CharacterFlyweightFactory();

        var rnd = new Random();

        foreach (char c in document)
        {
            var flyweight = factory.GetFlyweight(c);
            // Внешнее состояние — позиция символа на экране
            int x = rnd.Next(0, 100);
            int y = rnd.Next(0, 100);
            flyweight.Draw(x, y);
        }
    }
}
