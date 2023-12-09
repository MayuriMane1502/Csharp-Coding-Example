using System;

public class Customer
{
    /*private int _id;

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }*/

    protected int ID; // we can only user this in derived class
}

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new CorporateCustomer();
        CC.ID = 101; // we can access protected fields in the derived class

        base.ID = 102;
    }
}
public class Program
{
    public static void Main()
    {

    }
}