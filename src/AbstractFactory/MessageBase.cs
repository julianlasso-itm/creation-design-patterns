namespace AbstractFactory;

public abstract class MessageBase : IMessage
{
    protected readonly TransportBase Transport;

    public MessageBase(TransportBase transport)
    {
        Transport = transport;
    }

    public abstract void Send(String destination, String message);

    protected static void LogMessage(String message)
    {
        Console.WriteLine($"Message: {message}");
    }
}
