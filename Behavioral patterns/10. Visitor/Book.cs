namespace Visitor;

public class Book : IShoppingItem
{
    public string Title { get; }
    public double Price { get; }

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

