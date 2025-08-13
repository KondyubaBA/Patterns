namespace Template_Method;

public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
    {
        Console.WriteLine("Читаем данные из CSV файла.");
    }

    protected override void ProcessData()
    {
        Console.WriteLine("Обрабатываем CSV данные.");
    }
}
