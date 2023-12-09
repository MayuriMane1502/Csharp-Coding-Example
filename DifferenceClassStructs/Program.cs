using System;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Program
{
    static void Main()
    {
        int i = 10;
        int j = i;
        j = i + 1;

        Console.WriteLine("i= {0} && j ={1}", i, j); // value type - when you copy value type you will pointing to different memory and different values printed
        Customer C1 = new Customer();
        C1.Id = 101;
        C1.Name = "Mayuri";

        Customer C2 = C1;

        C2.Name = " Jack";

        Console.WriteLine("C1.Name = {0} && C2.Name ={1}", C1.Name, C2.Name); // refernce type - when you copy the reference type you will pointing to the same memory and value changed will be printed in both different refernce
        //same values will be printed in both refernce
    }
}