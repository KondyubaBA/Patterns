namespace Singleton;

public class Logger
{
    // Хранит единственный экземпляр класса Logger
    private static Logger _instance;

    // Объект для синхронизации доступа к экземпляру
    private static readonly object _lock = new object();

    // Приватный конструктор, чтобы предотвратить создание экземпляров извне
    private Logger() { }

    // Публичный метод для получения единственного экземпляра класса
    public static Logger Instance
    {
        get
        {
            // Используем двойную проверку для ленивой и потокобезопасной инициализации
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }
    }

    // Метод для записи логов
    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}

