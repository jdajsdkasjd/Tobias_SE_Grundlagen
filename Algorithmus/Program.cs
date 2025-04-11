/*
int[] cards = [3, 5, 7, 8, 9];
int[] cards2 = new int[50000000];
// 50_000_000
// 25_000_000
// 12_500_000
// 6_250_000
for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i + 1;
}

// int[] cards = {3, 5, 7, 8, 9};
int query = 9;

var result = Algorithms.FindCardLocationBinarySearch(cards, query);
Console.WriteLine("Index von gesuchtem Element in cards: " + result);
// Console.WriteLine(cards2[10]);
var result2 = Algorithms.FindCardLocationBinarySearch(cards2, 40_942_069); // 40_942_068
Console.WriteLine("Index von gesuchtem Element in cards2: " + result2);
*/
using BenchmarkDotNet.Running;

// var algos = new Algorithms();

var summary = BenchmarkRunner.Run<Algorithms>();

// test insertion sort with small array
/*
var unsortedArray = new int[] { 5, 3, 8, 6, 2 };
Console.WriteLine("Unsortiertes Array: " + string.Join(", ", unsortedArray));
var sortedArray = Algorithms.InsertionSort(unsortedArray);

Console.WriteLine("Sortiertes Array: " + string.Join(", ", sortedArray));
*/