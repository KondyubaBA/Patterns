namespace Prototype;

/// <summary>
/// Паттерн "Прототип" (Prototype) позволяет создавать новые объекты путем копирования существующих, 
/// что особенно полезно, когда создание экземпляров объектов является затратным по времени или ресурсам. 
/// В этом паттерне используется метод клонирования, чтобы создать новые объекты на основе уже существующих.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        // Создание оригинального автомобиля
        Car originalCar = new Car("Toyota", "Camry", 2021);
        Console.WriteLine("Original Car: " + originalCar);

        // Клонирование автомобиля
        Car clonedCar = (Car)originalCar.Clone();
        Console.WriteLine("Cloned Car: " + clonedCar);

        // Изменение свойств клонированного автомобиля
        clonedCar.Year = 2022;
        Console.WriteLine("After modifying cloned car:");
        Console.WriteLine("Original Car: " + originalCar);
        Console.WriteLine("Cloned Car: " + clonedCar);
    }
}
