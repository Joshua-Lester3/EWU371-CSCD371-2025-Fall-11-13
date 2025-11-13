namespace ConsoleApp2;

public class Program : IDisposable
{
    public TempFile Temp { get; private set; }

    public Program()
    {
        using TempFile file = new TempFile();
        Temp = file;
    }

    public static void Main(string[] args)
    {
        Program program = new();
        program.Function2();
    }

    public void Function2()
    {
        StreamReader temp2 = new("text.txt");
    }

    public void Dispose()
    {
        Temp.Dispose();
    }

    ~Program()
    {
        Dispose();
    }
}
