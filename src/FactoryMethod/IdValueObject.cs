namespace FactoryMethod;

public class IdValueObject : IValueObject<int>
{
    private readonly int _id;
    private const int MIN_VALUE = 1;

    public IdValueObject(int id)
    {
        _id = id;
    }

    public int GetValue()
    {
        return _id;
    }

    public bool IsValid()
    {
        return _id >= MIN_VALUE;
    }
}
