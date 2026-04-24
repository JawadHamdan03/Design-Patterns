namespace Decorator;

public class WhippedCreamDecorator : BeverageDecorator
{
    public WhippedCreamDecorator(Beverage beverage) : base(beverage)
    {
        
    }

    public override string getDescription()
    {
        return base.getDescription()+ ", WhippedCreamDecorator";
    }

    public override double getCost() => base.getCost() + 1;

}