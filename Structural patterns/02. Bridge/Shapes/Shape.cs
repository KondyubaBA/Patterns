using Bridge.Drawing;

namespace Bridge.Shapes;

public abstract class Shape
{
    protected IDrawingAPI drawingAPI;

    protected Shape(IDrawingAPI drawingAPI)
    {
        this.drawingAPI = drawingAPI;
    }

    public abstract void Draw();
}
