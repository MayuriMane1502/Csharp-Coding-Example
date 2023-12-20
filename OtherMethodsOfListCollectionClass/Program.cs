using System;
using System.Collections.ObjectModel;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Johnny",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Shwan",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Sam",
                Salary = 5000
            };

            List<Customer> listCustomer = new List<Customer>(100); //constructor value =100 but only 3 items are present
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            ReadOnlyCollection<Customer> readOnlyCustomers = listCustomer.AsReadOnly();
           Console.WriteLine("Items = "+ readOnlyCustomers.Count);

            Console.WriteLine("Are all salaries greater than 3000: {0} ", listCustomer.TrueForAll(x => x.Salary > 3000));

            //to check the capacity
            Console.WriteLine("Capacity before trimming = " + listCustomer.Capacity);
            listCustomer.TrimExcess();
            Console.WriteLine("Capacity after trimming = " + listCustomer.Capacity);
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}