using System;
public class Program
{
    public static void Main()
    {
        //create customer array
        Customer[] customers = new Customer[3];
        customers[0] = new Customer 
        { 
            Name = "Mark", 
            Gender = Gender.Male //chnage -4 ->chng the numeric values to Gender = 1 to Gender= Gender.Male
        };
        customers[1] = new Customer 
        { 
            Name = "Jenny", 
            Gender = Gender.Female 
        };
        customers[2] = new Customer 
        { 
            Name = "Sam", 
            Gender = Gender.Unknown 
        };

        foreach (Customer customer in customers)
        {
            Console.WriteLine("Customer Name = {0} && gender = {1}", customer.Name, GetGender(customer.Gender));
        }
    }
    public static string GetGender(Gender gender) //instead of passing int gender chng it to Gender gender
        //change -3
    {
        switch (gender)
        {
            case Gender.Unknown:
                return "Unknown";
            case Gender.Male: 
                return "Male";
            case Gender.Female: 
                return "Female";
            default: 
                return "Invalid data detected";
        }
    }
}

public enum Gender // chnage 1
{
    Unknown,
    Male,
    Female
}
public class Customer
{
    public string Name { get; set; }
    //chnage int data type of gender to Gender // change 2
    public Gender Gender { get; set; } // 0-unknown 1-Male 2- female

}