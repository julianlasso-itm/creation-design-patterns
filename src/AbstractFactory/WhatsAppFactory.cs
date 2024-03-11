namespace AbstractFactory;

public class WhatsAppFactory : IMessageFactory
{
    public IMessage CreateMessage()
    {
        return new MessageWhatsApp(new WhatsAppTransport());
    }
}
