namespace Memento;

public class SnapshotManager
{
    private readonly List<TextSnapshot> _snapshots = [];

    public void SaveSnapshot(TextSnapshot snapshot)
    {
        _snapshots.Add(snapshot);
    }

    public TextSnapshot GetSnapshot(int index)
    {
        if (index < 0 || index >= _snapshots.Count)
        {
            throw new IndexOutOfRangeException("Snapshot index out of range.");
        }
        return _snapshots[index];
    }
}
