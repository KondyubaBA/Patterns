namespace Builder;

internal class Program
{
    static void Main(string[] args)
    {
        IHouseBuilder builder = new ConcreteHouseBuilder();
        HouseDirector director = new HouseDirector(builder);

        director.Construct();

        House house = builder.GetResult();
        Console.WriteLine(house);
    }
}
