namespace AbstractFactory;

public abstract class MessageBase : IMessage
{
    protected readonly TransportBase _transport;

    public MessageBase(TransportBase transport)
    {
        _transport = transport;
    }

    public abstract void Send(String destination, String message);

    protected void LogMessage(String message)
    {
        Console.WriteLine($"Message: {message}");
    }
}
