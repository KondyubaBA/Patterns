namespace Bridge.Drawing;

public interface IDrawingAPI
{
    void DrawCircle(double x, double y, double radius);
    void DrawRectangle(double x, double y, double width, double height);
}