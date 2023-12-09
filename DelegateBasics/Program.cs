using System;

public delegate void HelloFunctionDelegate(string Message);
public class Program
{
    public static void Main()
    {
        //create a instance of the delegate
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello); // instance call the hello function
        del("Hello From Delegate"); //this string will be passed to the function stringMessage
    }
    public static void Hello(string strMessage) // method has return type(void) method name(hello) parameter
    {
        Console.WriteLine(strMessage);
    }
}