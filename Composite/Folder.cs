namespace Composite;

class Folder : FileSystemCompnent
{
    private string name;
    public List<FileSystemCompnent> components;
 
    public Folder(string name)
    {
        this.name = name;
        components = new List<FileSystemCompnent>();
    }

    public void addComponent(FileSystemCompnent compnent)
    {
        components.Add(compnent);
    }

    public void removeComponent(FileSystemCompnent compnent)
    {
        components.Remove(compnent);
    }




    public void showDetails()
    {
        Console.WriteLine($"name : {name}");
        foreach(var comp in components)
        {
            comp.showDetails();
        }
    }
}