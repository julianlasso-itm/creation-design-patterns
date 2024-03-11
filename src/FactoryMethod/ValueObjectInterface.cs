namespace FactoryMethod;

public interface IValueObject<Type>
{
    public Type GetValue();
    public bool IsValid();
}
