namespace Decorator;

public abstract class BeverageDecorator : Beverage
{
    private Beverage _beverage;
    protected BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }
    public virtual double getCost()
    {
       return _beverage.getCost();
    }

    public virtual string getDescription()
    {
       return  _beverage.getDescription();
    }
}
