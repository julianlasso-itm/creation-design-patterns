namespace FactoryMethod;

public class IdValueObjectHandler : ValueObjectHandlerBase<int>
{
    public override IValueObject<int> CreateValueObject(int value)
    {
        return new IdValueObject(value);
    }
}
