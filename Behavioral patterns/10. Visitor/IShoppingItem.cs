namespace Visitor;

public interface IShoppingItem
{
    void Accept(IVisitor visitor);
}

