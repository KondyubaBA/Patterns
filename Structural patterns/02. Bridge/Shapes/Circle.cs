using Bridge.Drawing;

namespace Bridge.Shapes;

public class Circle : Shape
{
    private double x, y, radius;

    public Circle(double x, double y, double radius, IDrawingAPI drawingAPI) : base(drawingAPI)
    {
        this.x = x;
        this.y = y;
        this.radius = radius;
    }

    public override void Draw()
    {
        drawingAPI.DrawCircle(x, y, radius);
    }
}
