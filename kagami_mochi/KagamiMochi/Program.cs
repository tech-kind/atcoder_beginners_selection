using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);

        int result = 0;
        int tmp = -1;
        for (int i = 0;i < n;i++)
        {
            if (numbers[i] > tmp)
            {
                result++;
                tmp = numbers[i];
            }
        }
        Console.WriteLine($"{result}");
    }
}
