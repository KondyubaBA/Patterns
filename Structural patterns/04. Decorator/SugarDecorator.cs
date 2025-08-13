namespace Decorator;

public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", сахар";
    }

    public override double GetCost()
    {
        return beverage.GetCost() + 0.20; // Цена за сахар
    }
}