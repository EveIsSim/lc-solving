namespace EveIsSim.LCSolving.Csharp.Tools;

public class Watcher
{
    private System.Diagnostics.Stopwatch _watch = new();

    public void Start()
    {
        _watch.Start();
    }

    public void Stop()
    {
        _watch.Stop();
        Console.WriteLine($"Execution Time: {_watch.ElapsedMilliseconds} ms");
    }
}
