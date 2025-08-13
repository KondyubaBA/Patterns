namespace Memento;

public class TextEditor
{
    private string _text;

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public TextSnapshot CreateSnapshot()
    {
        return new TextSnapshot(_text);
    }

    public void RestoreSnapshot(TextSnapshot snapshot)
    {
        _text = snapshot.Text;
    }
}
