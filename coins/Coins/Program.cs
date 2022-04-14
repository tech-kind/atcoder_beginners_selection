using System;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        int sum = 0;
        for(int i = 0; i <= a; i++)
        {
            for(int j = 0; j <= b; j++)
            {
                for (int k = 0; k <= c; k++)
                {
                    if (x == i * 500 + j * 100 + k * 50)
                        sum++;
                }
            }
        }

        Console.WriteLine($"{sum}");
    }
}
