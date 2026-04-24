namespace Decorator;

public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage) : base(beverage)
    {
        
    }

    public override string getDescription()
    {
        return base.getDescription() + ", milk";
    }


    public override double getCost()
    {
        return base.getCost()+1;
    }
}
