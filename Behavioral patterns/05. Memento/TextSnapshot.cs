namespace Memento;

public class TextSnapshot
{
    public string Text { get; private set; }

    public TextSnapshot(string text)
    {
        Text = text;
    }
}
