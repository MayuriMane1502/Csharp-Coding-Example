using System;
public class Program
{
    public static void Main()
    {
        Add(10, 20);
        Add(10, 2, 5);
    }
    public static void Add(int FN, int SN)
    {
        Console.WriteLine("Sum- {0}", FN + SN);
    }

    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum- {0}", FN + SN+TN);
    }
}
