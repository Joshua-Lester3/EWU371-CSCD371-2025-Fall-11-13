namespace ConsoleApp2;

public class TempFile : IDisposable
{

    ~TempFile()
    {
        Dispose();
        Console.WriteLine("TempFile finalizer running...");
    }

    public void Dispose()
    {
        Console.WriteLine("Disposing...");
        Console.WriteLine("Cleaning up object...");
        GC.SuppressFinalize(this);
    }
}
