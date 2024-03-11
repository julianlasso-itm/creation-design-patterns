namespace FactoryMethod;

public class NameValueObject : IValueObject<string>
{
    private readonly string _name;
    private const int MIN_LENGTH = 3;
    private const int MAX_LENGTH = 50;

    public NameValueObject(string name)
    {
        _name = name;
    }

    public string GetValue()
    {
        return _name;
    }

    public bool IsValid()
    {
        if (string.IsNullOrEmpty(_name)) return false;
        else if (_name.Length < MIN_LENGTH) return false;
        else if (_name.Length > MAX_LENGTH) return false;
        return true;
    }
}
