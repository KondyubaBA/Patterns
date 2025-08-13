namespace Builder;

public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildWalls();
    void BuildRoof();
    House GetResult();
}

