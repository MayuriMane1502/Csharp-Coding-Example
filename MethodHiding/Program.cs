using System;

public class Employee
{
    public string _firstName;
    public string _lastName;

    public void printFullName ()
    {
        Console.WriteLine(_firstName+" "+_lastName);
    }
}

public class PartTimeEmployee : Employee
{
    public new void printFullName() // this method hides the Employee class printFullName method
    //above line we are getting warning so to avoid that warning we are using new keyword
    {
        //to call the parent class i.e Employee class method inside the derived class method you can use base keyword
        base.printFullName();

        Console.WriteLine(_firstName + " " + _lastName + " - Contractor");
    }
}
public class FullTimeEmployee :Employee
{

}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE._firstName = "FullTimeEMployee";
        FTE._lastName = "Mayuri";
        FTE.printFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE._firstName = "PartimeEmployee";
        PTE._lastName = "Johnny";
        PTE.printFullName(); // it will be the PartTimeClass method
        //to call the parent class printFullName() we can use type caste method

        ((Employee) PTE).printFullName();
    }
}