using System.Diagnostics;

namespace SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

public abstract class BaseSort
{
    public void Calculate(int[] arr)
    {
        var timer = new Stopwatch();
        timer.Start();
        Sort(arr);
        timer.Stop();
        Console.WriteLine($"{GetType().Name} {arr.Length} items sort time: {timer.ElapsedMilliseconds}ms");
    }

    protected abstract void Sort(int[] arr);
}