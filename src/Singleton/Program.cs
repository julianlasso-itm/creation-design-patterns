namespace  Singleton;

public static class Program {
    public static void Main() {
        CalculatorHandler calculator1 = CalculatorHandler.GetInstance();

        calculator1.SetValue(10)
            .Add(5)
            .Multiply(2)
            .Subtract(10)
            .Divide(2);

        Console.WriteLine(calculator1.GetResult()); // Output: 10

        CalculatorHandler calculator2 = CalculatorHandler.GetInstance();

        calculator2.Add(8)
            .Multiply(3)
            .Subtract(20)
            .Divide(4);

        Console.WriteLine(calculator2.GetResult()); // Output: 8,5
    }
}
