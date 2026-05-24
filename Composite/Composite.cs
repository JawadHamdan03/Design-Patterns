using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite;

public class Composite : Component
{
    public List<Component> children = new List<Component>();
    public Composite(string name) : base(name)
    {

    }

    public override void Add(Component component)
    {
        children.Add(component);
    }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new string('-',depth)+Name);
        foreach (var item in children)
        {
            item.PrimaryOperation(depth+2);
        }
    }

    public override void Remove(Component component)
    {
        children.Remove(component);
    }
}
