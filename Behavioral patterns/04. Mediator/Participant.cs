namespace Mediator;

public abstract class Participant
{
    protected IMediator Mediator;

    public void SetMediator(IMediator mediator)
    {
        Mediator = mediator;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
