namespace Factory_Method;

public class CarFactory : VehicleFactory
{
    public override Vehicle CreateVehicle()
    {
        return new Car();
    }
}
