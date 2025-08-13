namespace Visitor;

public class Food : IShoppingItem
{
    public string Name { get; }
    public double Price { get; }

    public Food(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

