namespace AbstractFactory;

public class MessageWhatsApp : MessageBase
{
    public MessageWhatsApp(TransportBase transport) : base(transport) { }

    public override void Send(String destination, String message)
    {
        LogMessage($"Send by WhatsApp: {message}");
        Transport.MessageFor(destination);
        Transport.SendMessage(message);
    }
}
