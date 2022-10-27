// See https://aka.ms/new-console-template for more information

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