namespace AbstractFactory;

enum TransportType
{
    Email,
    WhatsApp
}

public class Program
{
    private static IMessageFactory? s_factory;
    public static void Main()
    {
        s_factory = GetFactory(TransportType.Email);
        var email = s_factory.CreateMessage();
        email.Send("destination@email.com", "Message for Email");

        s_factory = GetFactory(TransportType.WhatsApp);
        var whatsApp = s_factory.CreateMessage();
        whatsApp.Send("1234567890", "Message for WhatsApp");
    }

    private static IMessageFactory GetFactory(TransportType type)
    {
        return type switch
        {
            TransportType.Email => new EmailFactory(),
            TransportType.WhatsApp => new WhatsAppFactory(),
            _ => throw new NotImplementedException()
        };
    }
}
