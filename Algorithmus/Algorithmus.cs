using BenchmarkDotNet.Attributes;

public class Algorithmus
{
    public Algorithmus()
    {

    int[] cards = new int [50000000];
    for (int i = 0; i < cards.Length; i++)
    {
        cards[i] = i + 1;
    }


    }
// Binary Search => O(log(n)) = Komplexiät des Algorithmus
[Benchmark] 
public static int FindCardLocationBinarySearch(int[] cards, int query)

{
    int min = 0;
    int max = cards.Length - 1;
 
    while (min <= max)
    {
        int mid = (min + max) / 2;
 
        if (query == cards[mid])
        {
            return mid;
        }
        else if (query < cards[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return -1;
}
 
// Linear Search => O(n) = Komplexiät des Algorithmus
[Benchmark] 
public static int FindCardLocation(int[] cards, int query)
{
   
    int index = 0;
    while (index < cards.Length)
    {
        if (cards[index] == query)
            return index;
        index++; // index = index + 1;
    }
    return -1;
}
}
