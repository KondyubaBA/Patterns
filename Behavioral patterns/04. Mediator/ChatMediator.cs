namespace Mediator;

/// <summary>
/// Конкретный посредник
/// </summary>
public class ChatMediator : IMediator
{
    private readonly List<Participant> _participants = [];

    public void Register(Participant participant)
    {
        _participants.Add(participant);
        participant.SetMediator(this);
    }

    public void Notify(object sender, string ev)
    {
        foreach (var participant in _participants)
        {
            // Не уведомляем отправителя
            if (participant != sender)
            {
                participant.Receive(ev);
            }
        }
    }
}
