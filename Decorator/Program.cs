namespace Decorator;

public class Program
{
    static void Main(string[] args)
    {
        Beverage beverage = new PlainCoffe();
        Console.WriteLine(beverage.getDescription() + ", " + beverage.getCost());

        // add milk 
        BeverageDecorator milkDecorator = new MilkDecorator(beverage);
        Console.WriteLine(milkDecorator.getDescription() + ", " + milkDecorator.getCost());


        // add sugar 
        BeverageDecorator sugarDecorator = new SugarDecorator(beverage);
        Console.WriteLine(sugarDecorator.getDescription() + ", " + sugarDecorator.getCost());

        // add WhippedCream
        BeverageDecorator whippedCreamDecorator = new WhippedCreamDecorator(beverage);
        Console.WriteLine(whippedCreamDecorator.getDescription()+", "+ whippedCreamDecorator.getCost());
    }
}
