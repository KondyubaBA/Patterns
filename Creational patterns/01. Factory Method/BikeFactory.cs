namespace Factory_Method;

public class BikeFactory : VehicleFactory
{
    public override Vehicle CreateVehicle()
    {
        return new Bike();
    }
}
