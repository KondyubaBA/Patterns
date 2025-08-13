namespace Template_Method;

public class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Читаем данные из XML файла.");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Обрабатываем XML данные.");
    }

    protected override void SaveData()
    {
        Console.WriteLine("Сохраняем данные в XML формате.");
    }
}
