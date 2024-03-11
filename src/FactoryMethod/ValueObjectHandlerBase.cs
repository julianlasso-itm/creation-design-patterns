namespace FactoryMethod;

public abstract class ValueObjectHandlerBase<Type>
{
    public abstract IValueObject<Type> CreateValueObject(Type value);

    public void ValidateValueObject(IValueObject<Type> valueObject)
    {
        if (!valueObject.IsValid())
        {
            throw new ArgumentException("Invalid value");
        }
    }
}
