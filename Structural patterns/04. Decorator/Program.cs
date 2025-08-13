namespace Decorator;

class Program
{
    static void Main()
    {
        // Заказ простого кофе
        IBeverage myCoffee = new Coffee();
        Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost():C}");

        // Заказ кофе с молоком
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost():C}");

        // Заказ кофе с молоком и сахаром
        myCoffee = new SugarDecorator(myCoffee);
        Console.WriteLine($"{myCoffee.GetDescription()} - {myCoffee.GetCost():C}");
    }
}
