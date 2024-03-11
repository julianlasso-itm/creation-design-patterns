namespace Builder;

public class Program
{
    public static void Main()
    {
        IOrderBuilder orderBuilder = new OrderBuilder();
        Order order = orderBuilder
            .SetDishType(EDishType.PIZZA)
            .SetAdditions(new List<EAddition> { EAddition.CHEESE, EAddition.ONION })
            .SetSize(ESize.LARGE)
            .Build();
        Console.WriteLine(order.ToString());

        order = orderBuilder
            .SetDishType(EDishType.PASTA)
            .SetSize(ESize.SMALL)
            .Build();
        Console.WriteLine(order.ToString());
    }
}
