using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        input = input.Replace("eraser", "");
        input = input.Replace("erase", "");
        input = input.Replace("dreamer", "");
        input = input.Replace("dream", "");

        Console.WriteLine(input.Length == 0 ? "YES" : "NO");
    }
}
