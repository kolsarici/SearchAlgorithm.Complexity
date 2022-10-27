namespace SearchAlgorithms.Complexity.ConsoleApp.Helpers;

public static class ArrayHelper
{
    public static int[] Populate(int size)
    {
        return Enumerable.Repeat(0, size).Select(i => new Random().Next()).ToArray();
    }
}