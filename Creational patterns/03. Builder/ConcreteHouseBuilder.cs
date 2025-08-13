namespace Builder;

public class ConcreteHouseBuilder : IHouseBuilder
{
    private House _house = new House();

    public void BuildFoundation()
    {
        _house.Foundation = "Concrete foundation";
    }

    public void BuildWalls()
    {
        _house.Walls = "Concrete walls";
    }

    public void BuildRoof()
    {
        _house.Roof = "Concrete roof";
    }

    public House GetResult()
    {
        return _house;
    }
}

