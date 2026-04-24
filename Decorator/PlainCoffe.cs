namespace Decorator;

public class PlainCoffe : Beverage
{
    public string getDescription()
    {
        return "Plain Coffe";
    }

    public double getCost()
    {
        return 3.0;
    }
}
