namespace Decorator;

public class Coffee : IBeverage
{
    public string GetDescription()
    {
        return "Простой кофе";
    }

    public double GetCost()
    {
        return 2.00; // Базовая цена
    }
}