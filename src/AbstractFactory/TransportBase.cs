namespace AbstractFactory;

public abstract class TransportBase
{
    protected String? _destination;

    public void MessageFor(String destination)
    {
        _destination = destination;
    }

    public abstract void SendMessage(String message);
}
