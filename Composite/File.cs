namespace Composite;

class File : FileSystemCompnent
{
    private string name;
    public File(string name )
    {
        this.name = name;
    }
    public void showDetails()
    {
        Console.WriteLine($"File : {name} ");
    }
}
