using System;
interface I1
{
    void IterfaceMethod();
}

interface I2
{
    void IterfaceMethod();
}

public class Program : I1,I2
{
    void I1.IterfaceMethod() // exlicit method implementation
    {
        Console.WriteLine("Interface Method - 1 printed");
    }

    void I2.IterfaceMethod() // exlicit method implementation
    {
        Console.WriteLine("Interface Method - 2 printed");
    }
    public static void Main()
    {
        Program P = new Program();
        ((I1)P).IterfaceMethod(); //casting interface explicitly to call the same method
        ((I2)P).IterfaceMethod();

        // if you don't want to use casting method then use 

        I1 i1 = new Program();
        I2 i2 = new Program();

        i1.IterfaceMethod();
        i2.IterfaceMethod();
    }
}