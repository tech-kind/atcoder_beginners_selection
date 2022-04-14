using System;

class Program
{
    static void Main(string[] args)
    {
        int countInt = int.Parse(Console.ReadLine());
        string[] split = Console.ReadLine().Split(' ');

        Span<int> vs = stackalloc int[countInt];
        for (int i = 0; i < countInt; i++)
        {
            vs[i] = int.Parse(split[i]);
        }

        int result = 0;
        while(CheckAllEven(vs))
        {
            CalcHalfValue(vs);
            result++;
        }
        Console.WriteLine($"{result}");
        Console.ReadLine();
    }

    static bool CheckAllEven(Span<int> vs)
    {
        for (int i = 0; i < vs.Length; i++)
        {
            if (vs[i] % 2 != 0)
                return false;
        }
        return true;
    }

    static void CalcHalfValue(Span<int> vs)
    {
        for (int i = 0; i < vs.Length; i++)
        {
            vs[i] /= 2;
        }
    }
}
