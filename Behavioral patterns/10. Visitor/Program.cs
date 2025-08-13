namespace Visitor;

internal class Program
{
    static void Main(string[] args)
    {
        // Создаем элементы магазина
        IShoppingItem[] items = new IShoppingItem[]
        {
            new Book("C# Programming", 29.99),
            new Food("Apple", 0.99),
            new Book("Design Patterns", 39.99),
            new Food("Bread", 1.49)
        };

        // Создаем посетителя
        PriceCalculator calculator = new PriceCalculator();

        // Применяем посетителя ко всем элементам
        foreach (var item in items)
        {
            item.Accept(calculator);
        }

        // Выводим общую стоимость
        Console.WriteLine($"Общая стоимость: {calculator.TotalPrice}");
    }
}
