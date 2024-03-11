namespace Builder;

public class Order
{
    public DishType DishType { get; }
    public List<Addition> Additions { get; }
    public Size Size { get; }

    public Order(DishType dishType, List<Addition> additions, Size size)
    {
        DishType = dishType;
        Additions = additions;
        Size = size;
    }

    public override string ToString()
    {
        if (Additions.Count == 0) return $"Order: {DishType} in size {Size}";
        return $"Order: {DishType} with {string.Join(", ", Additions)} in size {Size}";
    }
}
