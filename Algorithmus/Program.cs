using System.Reflection.Emit;

int[] cards = [3, 5, 7, 8, 9];
int query = 7;

var result = FindCardLocation(cards, query);
Console.WriteLine(result);

int FindCardLocation(int[] cards, int query)
{
    int index = 0;                  
    while (index < cards.Length)
        {
        if (cards[index] == 7)
        return index;
        index++;
        }
    return -1;    //falls Wert nicht im Array enthalten
}
