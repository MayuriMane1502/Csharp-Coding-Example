using System;

interface ICustomer
{
    void Print(); // interface members are public by default
}

interface I2
{
    void I2();
}

class Customer : ICustomer , I2
{
    public void Print() //implementation of Interface Print method
    {
        Console.WriteLine("Interface Print Method");
    }

    public void I2()
    {
        Console.WriteLine("I2 Method");
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer();
        C1.Print();
        C1.I2();
    }
}
