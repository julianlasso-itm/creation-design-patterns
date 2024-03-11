namespace AbstractFactory;

public class EmailFactory : IMessageFactory
{
    public IMessage CreateMessage()
    {
        return new MessageEmail(new EmailTransport());
    }
}
