namespace FactoryMethod;

public static class Program
{
    private static ValueObjectHandlerBase<int>? s_personIdHandler;
    private static ValueObjectHandlerBase<string>? s_personNameHandler;
    private static ValueObjectHandlerBase<bool>? s_personEnabledHandler;

    public static void Configure(string typeValue)
    {
        switch (typeValue)
        {
            case "id":
                s_personIdHandler = new IdValueObjectHandler();
                break;
            case "name":
                s_personNameHandler = new NameValueObjectHandler();
                break;
            case "enabled":
                s_personEnabledHandler = new EnabledValueObjectHandler();
                break;
            default:
                throw new ArgumentException("Invalid type value");
        }
    }

    public static void Main()
    {
        Configure("id");
        Configure("name");
        Configure("enabled");

        IValueObject<int>? personId = s_personIdHandler?.CreateValueObject(1);
        IValueObject<string>? personName = s_personNameHandler?.CreateValueObject("John Doe");
        IValueObject<bool>? personEnabled = s_personEnabledHandler?.CreateValueObject(true);

        if (personId != null) s_personIdHandler?.ValidateValueObject(personId);
        if (personName != null) s_personNameHandler?.ValidateValueObject(personName);
        if (personEnabled != null) s_personEnabledHandler?.ValidateValueObject(personEnabled);

        Console.WriteLine("Person ID: " + personId?.GetValue());
        Console.WriteLine("Person Name: " + personName?.GetValue());
        Console.WriteLine("Person Enabled: " + personEnabled?.GetValue());
    }
}
