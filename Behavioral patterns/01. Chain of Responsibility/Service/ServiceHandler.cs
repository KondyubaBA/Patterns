namespace Chain_of_Responsibility.Service;

abstract class ServiceHandler
{
    protected ServiceHandler? _nextServiceHandler; //Следующий сервис
    protected ServiceRequirements _servicesProvided; //Поставщик текущего сервиса

    public ServiceHandler(ServiceRequirements servicesProvided)
    {
        _servicesProvided = servicesProvided;
    }

    private bool IsProvided(ServiceRequirements requirements)
        => (requirements & _servicesProvided) != 0;

    public void Service(Car car)
    {
        //Проверям требуется ли текущий сервис
        if (IsProvided(car.Requirements))
        { 
            //Выполнение сервиса
            Console.WriteLine($"{GetType().Name} providing {_servicesProvided} services.");
            car.Requirements &= ~_servicesProvided;
        }

        //Передаем в следубщий сервис
        if (!car.IsServiceComplete && _nextServiceHandler is not null)           
            _nextServiceHandler.Service(car);
    }

    public void SetNextServiceHandler(ServiceHandler handler)
        => _nextServiceHandler = handler;  
}
