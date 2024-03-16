namespace FactoryMethod;

public static class Program
{
    private static ValueObjectHandlerBase<int> PersonIdHandler;
    private static ValueObjectHandlerBase<string> PersonNameHandler;
    private static ValueObjectHandlerBase<bool> PersonEnabledHandler;

    public static void Configure(string typeValue)
    {
        switch (typeValue)
        {
            case "id":
                PersonIdHandler = new IdValueObjectHandler();
                break;
            case "name":
                PersonNameHandler = new NameValueObjectHandler();
                break;
            case "enabled":
                PersonEnabledHandler = new EnabledValueObjectHandler();
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

        IValueObject<int>? personId = PersonIdHandler?.CreateValueObject(1);
        IValueObject<string>? personName = PersonNameHandler?.CreateValueObject("John Doe");
        IValueObject<bool>? personEnabled = PersonEnabledHandler?.CreateValueObject(true);

        if (personId != null) PersonIdHandler?.ValidateValueObject(personId);
        if (personName != null) PersonNameHandler?.ValidateValueObject(personName);
        if (personEnabled != null) PersonEnabledHandler?.ValidateValueObject(personEnabled);

        Console.WriteLine("Person ID: " + personId?.GetValue());
        Console.WriteLine("Person Name: " + personName?.GetValue());
        Console.WriteLine("Person Enabled: " + personEnabled?.GetValue());
    }
}
