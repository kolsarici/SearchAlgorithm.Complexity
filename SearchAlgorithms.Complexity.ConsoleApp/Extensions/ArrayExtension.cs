namespace SearchAlgorithms.Complexity.ConsoleApp.Extensions;

public static class ArrayExtension
{
    public static void Print(this Array array)
    {
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine(" ");
    }
}