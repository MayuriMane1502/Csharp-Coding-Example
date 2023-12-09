using System;
public class Employee
{
    public string _firstName = "FN";
    public string _lastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(_firstName + " " + _lastName);
    }
}

public class PartTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(_firstName + " " + _lastName + " - Part Time");
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(_firstName + " " + _lastName + " - Full Time");
    }
}

public class TemporaryEmployee : Employee
{
    public override void PrintFullName() // if you do not write this method at run time the base class virtual method is called
    {
        Console.WriteLine(_firstName + " " + _lastName + " - Temporary");
    }
}
public class Program
{
    static void Main()
    {
        Employee [] employees = new Employee[4]; //array of an employees
        employees[0] = new Employee();
        employees[1] = new PartTimeEmployee(); //base class reference variable can point to child class object
        employees[2] = new FullTimeEmployee();
        employees[3] = new TemporaryEmployee();
        
        foreach(Employee e in employees)
        {
            e.PrintFullName();
        }
    }
}