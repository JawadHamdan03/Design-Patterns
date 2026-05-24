namespace Run;

using Composite;
public class Program
{
    static void Main(string[] args)
    {
        var root = new Composite("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        var comp1 = new Composite("Composite C1");
        comp1.Add(new Leaf("C1-LEAF A"));
        comp1.Add(new Leaf("C1-LEAF B"));
        
        var comp2 = new Composite("Composite C2");
        comp2.Add(new Leaf("C2-LEAF A"));
        comp1.Add(comp2);

        root.Add(comp1);
        
        root.PrimaryOperation(3);

        

    }
}
