namespace Memento;

/// <summary>
/// Паттерн Снимок (Memento) позволяет сохранять и восстанавливать состояние объекта, не нарушая инкапсуляции. 
/// Это полезно, когда вы хотите сохранить состояние объекта в определённый момент времени и затем восстановить его позже.
/// </summary>
class Program
{
    static void Main()
    {
        var editor = new TextEditor();
        var snapshotManager = new SnapshotManager();

        // Устанавливаем текст и сохраняем снимок
        editor.SetText("Version 1");
        snapshotManager.SaveSnapshot(editor.CreateSnapshot());

        // Устанавливаем новый текст и сохраняем снимок
        editor.SetText("Version 2");
        snapshotManager.SaveSnapshot(editor.CreateSnapshot());

        // Устанавливаем новый текст и сохраняем снимок
        editor.SetText("Version 3");
        snapshotManager.SaveSnapshot(editor.CreateSnapshot());

        // Восстанавливаем состояние из первого снимка
        editor.RestoreSnapshot(snapshotManager.GetSnapshot(0));
        Console.WriteLine(editor.GetText()); // Вывод: Version 1

        // Восстанавливаем состояние из второго снимка
        editor.RestoreSnapshot(snapshotManager.GetSnapshot(1));
        Console.WriteLine(editor.GetText()); // Вывод: Version 2
    }
}
