namespace Builder;

public class OrderBuilder : IOrderBuilder
{
    private DishType _dishType;
    private List<Addition>? _additions;
    private Size _size;

    public IOrderBuilder SetDishType(DishType dishType)
    {
        _additions = null;
        this._dishType = dishType;
        return this;
    }

    public IOrderBuilder SetAdditions(List<Addition> additions)
    {
        this._additions = additions;
        return this;
    }

    public IOrderBuilder SetSize(Size size)
    {
        _size = size;
        return this;
    }

    public Order Build()
    {
        return new Order(_dishType, _additions ?? new List<Addition>(), _size);
    }
}
