namespace SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

public class SelectionSort : BaseSort
{
    protected override void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            var temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}