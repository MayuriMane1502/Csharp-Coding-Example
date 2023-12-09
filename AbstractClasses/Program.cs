using System;

public abstract class Customer
{
    public abstract void Print(); 
}
public class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print Method");
    }
    public static void Main()
    {
        Customer C = new Program();
        C.Print();
    }
}