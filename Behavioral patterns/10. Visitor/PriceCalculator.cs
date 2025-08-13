namespace Visitor;

public class PriceCalculator : IVisitor
{
    public double TotalPrice { get; private set; } = 0;

    public void Visit(Book book)
    {
        TotalPrice += book.Price;
    }

    public void Visit(Food food)
    {
        TotalPrice += food.Price;
    }
}

