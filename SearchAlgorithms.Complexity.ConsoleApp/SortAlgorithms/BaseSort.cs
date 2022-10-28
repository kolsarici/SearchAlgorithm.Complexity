using System.Diagnostics;
using SearchAlgorithms.Complexity.ConsoleApp.Extensions;

namespace SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

public abstract class BaseSort
{
    public void Calculate(int[] arr)
    {
        //clone array before timer starts
        var cloneArray = (int[]) arr.Clone();
        
        var timer = new Stopwatch();
        timer.Start();
        Sort(cloneArray);
        timer.Stop();
        Console.WriteLine($"{GetType().Name} {cloneArray.Length} items sort time: {timer.ElapsedMilliseconds}ms");
    }

    protected abstract void Sort(int[] arr);
}