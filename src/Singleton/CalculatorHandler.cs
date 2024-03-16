namespace Singleton;

public class CalculatorHandler
{
    private float Memory { get; set; }
    private static CalculatorHandler? Instance;

    private CalculatorHandler()
    {
        Memory = 0;
    }

    public static CalculatorHandler GetInstance()
    {
        if (Instance == null) Instance = new CalculatorHandler();
        return Instance;
    }

    public float GetResult()
    {
        return Memory;
    }

    public CalculatorHandler Clear()
    {
        Memory = 0;
        return this;
    }

    public CalculatorHandler SetValue(int value)
    {
        Memory = value;
        return this;
    }

    public CalculatorHandler Add(int value)
    {
        Memory += value;
        return this;
    }

    public CalculatorHandler Subtract(int value)
    {
        Memory -= value;
        return this;
    }

    public CalculatorHandler Multiply(int value)
    {
        Memory *= value;
        return this;
    }

    public CalculatorHandler Divide(int value)
    {
        Memory /= value;
        return this;
    }

    public CalculatorHandler Modulus(int value)
    {
        Memory %= value;
        return this;
    }
}
