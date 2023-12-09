using System;

public struct Customer
{
    private int _id;
    private string _name;

    public int ID
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    { 
        get { return _name; }
        set { _name = value; }
    }

    //structs can have constructor
    public Customer (int Id,  string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._id, this._name);   
    }
}

public class Program
{
    static void Main()
    {
        Customer C1 = new Customer(101, "Mayuri"); // using constructor and passing 2 values to it
        C1.PrintDetails();

        Customer C2 = new Customer(); // default constructor
        C2.ID = 102; // we are using properties of struct to initialize the values 
        C2.Name = "Johnny";
        C2.PrintDetails();

        Customer C3 = new Customer //object initializer syntax
        {
            ID = 103,
            Name = "Jack"
        };
        C3.PrintDetails (); // to print 3rd customer details
    }
}