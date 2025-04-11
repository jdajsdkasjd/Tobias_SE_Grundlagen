/*
int[] cards = [3, 5, 7, 8, 9];
int[] cards2 = new int[50000000];

for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i + 1;
}
 
// int[] cards = {3, 5, 7, 8, 9};
int query = 9;

var result = Algorithmus.FindCardLocationBinarySearch(cards, query);
Console.WriteLine("Index von gesuchtem Element in cards: " + result);
// Console.WriteLine(cards2[10]);
var result2 = Algorithmus.FindCardLocationBinarySearch(cards2, 40_942_069); // 40_942_068
Console.WriteLine("Index von gesuchtem Element in cards2: " + result2);
*/
using BenchmarkDotNet.Attributes;

var summary = BenchmarkRunner.Run<Algorithmus>();