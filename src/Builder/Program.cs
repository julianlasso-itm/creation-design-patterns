namespace Builder;

public class Program
{
    public static void Main()
    {
        IOrderBuilder orderBuilder = new OrderBuilder();
        Order order = orderBuilder
            .SetDishType(DishType.PIZZA)
            .SetAdditions(new List<Addition> { Addition.CHEESE, Addition.ONION })
            .SetSize(Size.LARGE)
            .Build();
        Console.WriteLine(order.ToString());

        order = orderBuilder
            .SetDishType(DishType.PASTA)
            .SetSize(Size.SMALL)
            .Build();
        Console.WriteLine(order.ToString());
    }
}
