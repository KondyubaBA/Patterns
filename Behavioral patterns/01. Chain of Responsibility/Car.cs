namespace Chain_of_Responsibility;

class Car
{
    public ServiceRequirements Requirements { get; set; }

    public bool IsServiceComplete
    {
        get => Requirements == ServiceRequirements.None;       
    }
}
