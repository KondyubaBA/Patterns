namespace Chain_of_Responsibility.Service;

class Detailer : ServiceHandler
{
    public Detailer() : base(ServiceRequirements.Dirty) { }
}
