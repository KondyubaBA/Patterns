﻿namespace Bridge.Drawing;

public class ConsoleDrawingAPI : IDrawingAPI
{
    public void DrawCircle(double x, double y, double radius)
    {
        Console.WriteLine($"Drawing Circle at ({x}, {y}) with radius {radius} in Console.");
    }

    public void DrawRectangle(double x, double y, double width, double height)
    {
        Console.WriteLine($"Drawing Rectangle at ({x}, {y}) with width {width} and height {height} in Console.");
    }
}
