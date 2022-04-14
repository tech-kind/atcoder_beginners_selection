using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int n = int.Parse(split[0]);
        int a = int.Parse(split[1]);
        int b = int.Parse(split[2]);

        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            int sum = CalcSumOrder(i);
            if (sum >= a && sum <= b)
                result += i;
        }

        Console.WriteLine($"{result}");
    }

    static int CalcSumOrder(int value)
    {
        int sum = 0;
        int tmp = value;
        while (0 < tmp)
        {
            sum += (tmp % 10);
            tmp = (tmp / 10);
        }
        return sum;
    }
}
