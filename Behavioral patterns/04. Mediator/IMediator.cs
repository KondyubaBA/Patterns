namespace Mediator;

/// <summary>
/// Интерфейс посредника
/// </summary>
public interface IMediator
{
    void Notify(object sender, string ev);
}
