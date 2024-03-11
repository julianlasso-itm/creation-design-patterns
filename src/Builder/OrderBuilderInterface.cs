namespace Builder;

public interface IOrderBuilder
{
    public IOrderBuilder SetDishType(EDishType dishType);
    public IOrderBuilder SetAdditions(List<EAddition> additions);
    public IOrderBuilder SetSize(ESize size);
    public Order Build();
}
