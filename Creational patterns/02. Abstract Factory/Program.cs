using Abstract_Factory.MacOS;
using Abstract_Factory.Windows;

namespace Abstract_Factory;

class Program
{
    static void Main()
    {
        IGUIFactory factory;

        // Предположим, что мы определяем ОС динамически
        string os = "Windows"; // или "MacOS"

        if (os == "Windows")
            factory = new WindowsFactory();
        else
            factory = new MacOSFactory();

        var app = new Application(factory);
        app.Paint();
    }
}
