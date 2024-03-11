namespace AbstractFactory;

public class EmailTransport : TransportBase
{
    public override void Send(String message)
    {
        Console.WriteLine($"Send by Email to {_destination}: {message}");
    }
}
