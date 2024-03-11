namespace FactoryMethod;

public class NameValueObjectHandler : ValueObjectHandlerBase<string>
{
    public override IValueObject<string> CreateValueObject(string value)
    {
        return new NameValueObject(value);
    }
}
