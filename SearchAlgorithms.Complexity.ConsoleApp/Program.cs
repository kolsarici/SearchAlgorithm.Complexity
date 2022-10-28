using SearchAlgorithms.Complexity.ConsoleApp.Helpers;
using SearchAlgorithms.Complexity.ConsoleApp.SortAlgorithms;

var arr100 = ArrayHelper.Populate(100);
var arr1000 = ArrayHelper.Populate(1000);
var arr10000 = ArrayHelper.Populate(10000);
var arr100000 = ArrayHelper.Populate(100000);

new InsertionSort().Calculate(arr100);
new InsertionSort().Calculate(arr1000);
new InsertionSort().Calculate(arr10000);
new InsertionSort().Calculate(arr100000);
Console.WriteLine("------------------------------------------------");
new SelectionSort().Calculate(arr100);
new SelectionSort().Calculate(arr1000);
new SelectionSort().Calculate(arr10000);
new SelectionSort().Calculate(arr100000);
Console.WriteLine("------------------------------------------------");
new BubbleSort().Calculate(arr100);
new BubbleSort().Calculate(arr1000);
new BubbleSort().Calculate(arr10000);
new BubbleSort().Calculate(arr100000);