using System;

public class A
{
    public virtual void Print()
    {
        Console.WriteLine("A implementation");
    }
}

public class B : A
{
    public override void Print() 
    {
        Console.WriteLine("B implementation");
    }
}

public class C : A
{
    public override void Print()
    {
        Console.WriteLine("C implementation");
    }
}

public class D : B,C
{
    /*public override void Print()
    {
        Console.WriteLine("B implementation");
    }*/
}
public class Program
{
    public static void Main()
    {
        D d = new D();
        d.Print(); // it create ambiguity - diamond problem which print should be called
        //hence multiple inheritance is not possible in C#
    }
}