using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Span<int> t = stackalloc int[n + 1];
        Span<int> x = stackalloc int[n + 1];
        Span<int> y = stackalloc int[n + 1];

        t[0] = 0;
        x[0] = 0;
        y[0] = 0;

        for (int i = 0; i < n; i++)
        {
            string[] split = Console.ReadLine().Split(' ');
            t[i + 1] = int.Parse(split[0]);
            x[i + 1] = int.Parse(split[1]);
            y[i + 1] = int.Parse(split[2]);
        }

        bool can = true;
        for (int i = 0; i < n; i++)
        {
            int dt = t[i + 1] - t[i];
            int dist = Math.Abs(x[i + 1] - x[i]) + Math.Abs(y[i + 1] - y[i]);
            if (dt < dist) can = false;
            if (dist % 2 != dt % 2) can = false;
        }
        if (can)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
