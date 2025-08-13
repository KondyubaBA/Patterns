namespace Decorator;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", молоко";
    }

    public override double GetCost()
    {
        return beverage.GetCost() + 0.50; // Цена за молоко
    }
}
