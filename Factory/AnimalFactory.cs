using System;
using System.Collections.Generic;
using System.Text;

namespace Factory;

public class AnimalFactory
{

    public Animal createAnimal(string type)
    {
        Animal animal;
        switch (type!.ToLower())
        {
            case "cat":
                animal = new Cat();
                break;

            case "dog":
                animal = new Dog();
                break;

            case "cow":
                animal = new Cow();
                break;

            default:
                throw new Exception("invalid type");
                
        }
        return animal;
    }
}
