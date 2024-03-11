namespace AbstractFactory;

public class MessageEmail : MessageBase
{
    public MessageEmail(TransportBase transport) : base(transport) { }

    public override void Send(String destination, String message)
    {
        LogMessage($"Send by Email: {message}");
        Transport.MessageFor(destination);
        Transport.SendMessage(message);
    }
}
