using System;

class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int count = CountChar(s, '1');
        Console.WriteLine($"{count}");
    }

    static int CountChar(string s, char c)
    {
        return s.Length - s.Replace(c.ToString(), "").Length;
    }
}
