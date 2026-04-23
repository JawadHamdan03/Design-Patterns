namespace Composite;

public class Program
{
    static void Main(string[] args)
    {

        // Create files
        File file1 = new File("Document.txt");
        File file2 = new File("Photo.jpg");
        File file3 = new File("Video.mp4");

        // Create folders
        Folder folder1 = new Folder("Downloads");
        Folder folder2 = new Folder("Pictures");
        Folder folder3 = new Folder("Videos");

        // Add files to folders
        folder1.addComponent(file1);
        folder2.addComponent(file2);
        folder3.addComponent(file3);

        // Create a root folder and add folders to it
        Folder rootFolder = new Folder("Root");
        rootFolder.addComponent(folder1);
        rootFolder.addComponent(folder2);
        rootFolder.addComponent(folder3);
        rootFolder.showDetails();

    }
}
