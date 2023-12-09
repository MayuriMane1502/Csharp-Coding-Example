using System;

interface IA
{
    void AMethod();
}
class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("A Method");
    }
}

interface IB
{
    void BMethod();
}
class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("B Method");
    }
}

class AB : IA, IB
{
    A a = new A();
    B b = new B();  
    //we need to implement the method with the help of object
    public void AMethod()
    {
        a.AMethod(); // already method implementation is present above so just call wth of object variable
    }
    public void BMethod()
    {
        b.BMethod();

    }
}
public class Program
{
    static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}