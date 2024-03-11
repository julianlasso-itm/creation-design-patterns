namespace FactoryMethod;

public class EnabledValueObject : IValueObject<bool>
{
    private readonly bool _enable;

    public EnabledValueObject(bool enable)
    {
        _enable = enable;
    }

    public bool GetValue()
    {
        return _enable;
    }

    public bool IsValid()
    {
        if (_enable == true || _enable == false) return true;
        return false;
    }
}
