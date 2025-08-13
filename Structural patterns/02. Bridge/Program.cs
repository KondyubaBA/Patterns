using Bridge.Drawing;
using Bridge.Shapes;

namespace Bridge;

/// <summary>
/// Паттерн "Мост" (Bridge) — это структурный паттерн проектирования, который разделяет абстракцию и реализацию, 
/// позволяя им изменяться независимо друг от друга. Это достигается путем создания абстрактного класса, который 
/// содержит ссылку на объект реализации.
/// </summary>
class Program
{
    static void Main()
    {
        Shape circle = new Circle(5, 10, 3, new ConsoleDrawingAPI());
        circle.Draw();

        Shape rectangle = new Rectangle(1, 2, 3, 4, new GraphicDrawingAPI());
        rectangle.Draw();
    }
}
