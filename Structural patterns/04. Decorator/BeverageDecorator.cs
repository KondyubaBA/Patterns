namespace Decorator;

public abstract class BeverageDecorator : IBeverage
{
    protected IBeverage beverage;

    public BeverageDecorator(IBeverage beverage)
    {
        this.beverage = beverage;
    }

    public abstract string GetDescription();
    public abstract double GetCost();
}

