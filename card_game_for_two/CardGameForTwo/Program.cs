using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] split = Console.ReadLine().Split(' ');

        int[] cards = new int[n];
        for (int i = 0; i < n; i++)
        {
            cards[i] = int.Parse(split[i]);
        }
        
        Array.Sort(cards);
        Array.Reverse(cards);

        int alicePoint = 0;
        int BobPoint = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                alicePoint += cards[i];
            }
            else
            {
                BobPoint += cards[i];
            }
        }

        Console.WriteLine($"{alicePoint - BobPoint}");
    }
}
