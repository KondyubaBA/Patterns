namespace Template_Method;

/// <summary>
/// Абстрактный класс с шаблонным методом
/// </summary>
public abstract class DataProcessor
{
    // Шаблонный метод — определяет порядок выполнения шагов
    public void Process()
    {
        ReadData();
        ProcessData();
        SaveData();
    }

    protected abstract void ReadData();
    protected abstract void ProcessData();

    // Общий шаг с реализацией по умолчанию
    protected virtual void SaveData()
    {
        Console.WriteLine("Сохраняем данные в базу данных.");
    }
}

