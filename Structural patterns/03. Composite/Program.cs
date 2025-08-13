namespace Composite;

/// <summary>
/// Компоновщик (Composite) на C#. Этот паттерн позволяет работать с группой объектов так же, 
/// как с одним объектом, создавая древовидную структуру объектов.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        Branch root = new Branch("Root");

        // Создание веток и листьев
        Branch branch1 = new("Branch 1");
        branch1.Add(new Leaf("Leaf 1.1"));
        branch1.Add(new Leaf("Leaf 1.2"));

        Branch branch2 = new("Branch 2");
        branch2.Add(new Leaf("Leaf 2.1"));

        // Добавление веток к корню
        root.Add(branch1);
        root.Add(branch2);
        root.Add(new Leaf("Leaf 3"));

        // Отображение дерева
        root.Display(1);
    }
}

