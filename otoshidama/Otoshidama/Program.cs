using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int n = int.Parse(split[0]);
        int y = int.Parse(split[1]);

        for(int i = n; i >= 0; i--)
        {
            if ((i * 10000) > y)
                continue;

            for(int j = n; j >= 0; j--)
            {
                if ((i + j) > n)
                    continue;

                if ((i * 1000 + j * 5000) > y)
                    continue;

                int k = n - i - j;
                if ((i * 10000 + j * 5000 + k * 1000) == y)
                {
                    Console.WriteLine($"{i} {j} {k}");
                    return;
                }
            }
        }
        Console.WriteLine("-1 -1 -1");
    }
}
