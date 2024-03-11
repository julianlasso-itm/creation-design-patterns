namespace AbstractFactory;

public class WhatsAppTransport : TransportBase
{
    public override void Send(string message)
    {
        Console.WriteLine($"Sending message '{message}' to {_destination} using WhatsApp");
    }
}
