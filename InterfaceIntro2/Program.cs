using System;

interface ICustomer1
{
    void Print1(); // interface members are public by default
}

interface ICustomer2 : ICustomer1
{
    void Print2();
}

public class Customer : ICustomer2
{
    public void Print2() //implementation of Interface Print method
    {
        Console.WriteLine("Interface Print- 2 Method");
    }

    public void Print1() 
    {
        Console.WriteLine("Interface Print- 1 Method");
    }
}

public class Program
{
    public static void Main()
    {
        Customer C1 = new Customer(); // create a object
        C1.Print1();
        C1.Print2();

        ICustomer1 Cust = new Customer(); // refernce variable Icustomer1 is parent of Customer class
        Cust.Print1();
    }
}
