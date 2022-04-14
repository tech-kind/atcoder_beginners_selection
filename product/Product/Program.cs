using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split = Console.ReadLine().Split(' ');
        int a = int.Parse(split[0]);
        int b = int.Parse(split[1]);

        if (a % 2 == 0 || b % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}
