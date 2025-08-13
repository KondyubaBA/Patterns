namespace Singleton;

/// <summary>
/// Паттерн "Одиночка" (Singleton) гарантирует, что у класса есть только один экземпляр и предоставляет к нему глобальную точку доступа.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        // Получаем единственный экземпляр Logger
        Logger logger = Logger.Instance;

        // Записываем сообщения в лог
        logger.Log("Программа запущена.");
        logger.Log("Выполняется операция A.");
        logger.Log("Выполняется операция B.");
        logger.Log("Программа завершена.");
    }
}
