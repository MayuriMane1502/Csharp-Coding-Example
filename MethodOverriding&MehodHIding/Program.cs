using System; 
// method overriding example
/*public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base class print method");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("Derived class print method");
    }
}

public class Program
{
    static void Main()
    {
        BaseClass B = new DerivedClass();//created baseclass object but at run time it will decide which method to called
        B.Print(); // at runtime it will go to derived class method and print it
    }
} */

//--------------------Method Hiding Exmple ---------------------//

public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("Base class print method");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("Derived class print method");
    }
}

public class Program
{
    static void Main()
    {
        BaseClass B = new DerivedClass();
        B.Print(); // it will print the base class print() method

        //to print the derived class print() method create Derivedclass object

        DerivedClass D= new DerivedClass();
        D.Print();
    }
}