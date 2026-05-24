namespace Composite;

public abstract class Component
{
    public string Name { get;  }
    protected Component(string name )
    {
        Name = name;
    }
    
    public abstract void PrimaryOperation(int depth);
    public abstract void Add(Component component);
    public abstract void Remove(Component component);

}
