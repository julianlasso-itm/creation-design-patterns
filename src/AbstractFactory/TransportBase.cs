namespace AbstractFactory;

public abstract class TransportBase
{
    protected String? _destination;

    public void For(String destination)
    {
        _destination = destination;
    }

    public abstract void Send(String message);
}
