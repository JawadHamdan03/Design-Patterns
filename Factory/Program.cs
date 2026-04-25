namespace Factory;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the type of animal : ");
        string type =Console.ReadLine()!;

        AnimalFactory animalFactory = new AnimalFactory();
        var animal = animalFactory.createAnimal(type);

        animal.makeSound();

        
    }
}


