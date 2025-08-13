namespace Mediator;

/// <summary>
/// Паттерн Посредник (Mediator) используется для уменьшения зависимости между объектами, позволяя им 
/// взаимодействовать через посредника. Это упрощает коммуникацию и уменьшает связанность между компонентами.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        var mediator = new ChatMediator();

        var user1 = new User("Alice");
        var user2 = new User("Bob");
        var user3 = new User("Charlie");

        mediator.Register(user1);
        mediator.Register(user2);
        mediator.Register(user3);

        user1.Send("Привет всем!");
        user2.Send("Привет, Alice!");
    }
}
