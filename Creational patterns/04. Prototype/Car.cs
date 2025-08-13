namespace Prototype;

public class Car : IPrototype
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public IPrototype Clone()
    {
        return new Car(Make, Model, Year);
    }

    public override string ToString()
    {
        return $"{Year} {Make} {Model}";
    }
}

