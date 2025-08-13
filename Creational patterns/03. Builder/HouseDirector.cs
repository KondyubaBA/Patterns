namespace Builder;

public class HouseDirector
{
    private IHouseBuilder _builder;

    public HouseDirector(IHouseBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildFoundation();
        _builder.BuildWalls();
        _builder.BuildRoof();
    }
}

