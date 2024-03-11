namespace Builder;

public class Order
{
    public EDishType DishType { get; }
    public List<EAddition> Additions { get; }
    public ESize Size { get; }

    public Order(EDishType dishType, List<EAddition> additions, ESize size)
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
