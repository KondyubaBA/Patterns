namespace Composite;

class Leaf : TreeNode
{
    public Leaf(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}
