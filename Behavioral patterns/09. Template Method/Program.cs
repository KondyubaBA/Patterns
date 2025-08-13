namespace Template_Method;

internal class Program
{
    static void Main()
    {
        DataProcessor csvProcessor = new CsvDataProcessor();
        csvProcessor.Process();

        Console.WriteLine();

        DataProcessor xmlProcessor = new XmlDataProcessor();
        xmlProcessor.Process();
    }
}
