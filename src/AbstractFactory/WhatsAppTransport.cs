namespace AbstractFactory;

public class WhatsAppTransport : TransportBase
{
    public override void SendMessage(string message)
    {
        Console.WriteLine($"Sending message '{message}' to {_destination} using WhatsApp");
    }
}
