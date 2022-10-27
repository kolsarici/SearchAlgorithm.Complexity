namespace SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

public class InsertionSort : BaseSort
{
    protected override void Sort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            var temp = arr[i];
            var j = i - 1;
            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = temp;
        }
    }
}