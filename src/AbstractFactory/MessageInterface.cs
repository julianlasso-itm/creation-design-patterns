namespace AbstractFactory;

public interface IMessage
{
    public void Send(String destination, String message);
}
