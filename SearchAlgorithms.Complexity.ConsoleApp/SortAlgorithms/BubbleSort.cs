namespace SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

public class BubbleSort : BaseSort
{
    protected override void Sort(int[] arr)
    {
        var flag = true;
        for (int i = 0; i < arr.Length - 1 && flag; i++)
        {
            flag = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                    flag = true;
                }
            }
        }
    }
}