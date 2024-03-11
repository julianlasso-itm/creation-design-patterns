namespace Builder;

public class OrderBuilder : IOrderBuilder
{
    private EDishType _dishType;
    private List<EAddition>? _additions;
    private ESize _size;

    public IOrderBuilder SetDishType(EDishType dishType)
    {
        _additions = null;
        this._dishType = dishType;
        return this;
    }

    public IOrderBuilder SetAdditions(List<EAddition> additions)
    {
        this._additions = additions;
        return this;
    }

    public IOrderBuilder SetSize(ESize size)
    {
        _size = size;
        return this;
    }

    public Order Build()
    {
        return new Order(_dishType, _additions ?? new List<EAddition>(), _size);
    }
}
