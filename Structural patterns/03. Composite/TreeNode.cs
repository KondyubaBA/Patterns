namespace Composite;

abstract class TreeNode
{
    public string Name { get; protected set; }

    public TreeNode(string name)
    {
        Name = name;
    }

    public abstract void Display(int depth);
}
