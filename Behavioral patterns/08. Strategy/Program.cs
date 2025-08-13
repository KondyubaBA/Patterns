namespace Strategy;

/// <summary>
/// Паттерн Стратегия (Strategy) позволяет определять семейство алгоритмов, инкапсулировать каждый из них и делать их 
/// взаимозаменяемыми. Это позволяет клиентам выбирать алгоритм, не изменяя код, который их использует.
/// </summary>
internal class Program
{
    static void Main()
    {
        var context = new Context();

        // Используем стратегию сложения
        context.SetStrategy(new AddStrategy());
        Console.WriteLine("Сложение: " + context.ExecuteStrategy(5, 3)); // Вывод: 8

        // Используем стратегию вычитания
        context.SetStrategy(new SubtractStrategy());
        Console.WriteLine("Вычитание: " + context.ExecuteStrategy(5, 3)); // Вывод: 2

        // Используем стратегию умножения
        context.SetStrategy(new MultiplyStrategy());
        Console.WriteLine("Умножение: " + context.ExecuteStrategy(5, 3)); // Вывод: 15
    }
}
