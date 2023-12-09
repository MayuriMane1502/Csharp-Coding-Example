using System;
public class Program
{
    public static void Main()
    {
        //create customer array
        Customer[] customers = new Customer[3];
        customers[0] = new Customer { Name = "Mark", Gender = 1 };
        customers[1] = new Customer { Name = "Jenny", Gender = 2 };
        customers[2] = new Customer { Name = "Sam", Gender = 0 };

        foreach (Customer customer in customers)
        {
            Console.WriteLine("Customer Name = {0} && gender = {1}", customer.Name, GetGender(customer.Gender));
        }
    }
    public static string GetGender(int gender)
    {
        switch(gender)
        {
            case 0: return "Unknown";
            case 1: return "Male";
            case 2: return "Female";
            default: return "Invalid data detected";
        }
    }
}

public class Customer
{
    public string Name { get; set; }
    public int Gender { get; set; } // 0-unknown 1-Male 2- female

}