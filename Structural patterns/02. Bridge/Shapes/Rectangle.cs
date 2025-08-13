using Bridge.Drawing;

namespace Bridge.Shapes;

public class Rectangle : Shape
{
    private double x, y, width, height;

    public Rectangle(double x, double y, double width, double height, IDrawingAPI drawingAPI) : base(drawingAPI)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public override void Draw()
    {
        drawingAPI.DrawRectangle(x, y, width, height);
    }
}