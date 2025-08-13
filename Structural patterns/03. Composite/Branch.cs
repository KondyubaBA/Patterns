namespace Composite;

class Branch : TreeNode
{
    private List<TreeNode> children = [];

    public Branch(string name) : base(name) { }

    public void Add(TreeNode node)
    {
        children.Add(node);
    }

    public void Remove(TreeNode node)
    {
        children.Remove(node);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
        foreach (var child in children)
        {
            child.Display(depth + 2);
        }
    }
}
