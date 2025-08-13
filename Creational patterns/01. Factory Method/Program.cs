namespace Factory_Method;

class Program
{
    static void Main()
    {
        VehicleFactory carFactory = new CarFactory();
        Vehicle car = carFactory.CreateVehicle();
        car.Drive(); // Вывод: Driving a car.

        VehicleFactory bikeFactory = new BikeFactory();
        Vehicle bike = bikeFactory.CreateVehicle();
        bike.Drive(); // Вывод: Riding a bike.
    }
}
