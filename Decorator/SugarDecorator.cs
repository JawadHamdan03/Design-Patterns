namespace Decorator;

public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(Beverage beverage) : base(beverage)
    {
        
    }


    public override string getDescription()
    {
        return base.getDescription()+ ", Sugar";
    }

    public override double getCost()
    {
        return base.getCost()+0.5;
    }
}
