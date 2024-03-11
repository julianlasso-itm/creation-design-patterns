namespace Builder;

public interface IOrderBuilder
{
    public IOrderBuilder SetDishType(DishType dishType);
    public IOrderBuilder SetAdditions(List<Addition> additions);
    public IOrderBuilder SetSize(Size size);
    public Order Build();
}
