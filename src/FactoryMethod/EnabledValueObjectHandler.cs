namespace FactoryMethod;

public class EnabledValueObjectHandler : ValueObjectHandlerBase<bool>
{
    public override IValueObject<bool> CreateValueObject(bool value)
    {
        return new EnabledValueObject(value);
    }
}
