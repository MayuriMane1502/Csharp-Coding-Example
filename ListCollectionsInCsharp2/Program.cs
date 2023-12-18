using System;
namespace Mayuri
{
    public class Program
    {
        public static void Main()
        {
            //creating instances of class customer
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Johnny",
                Salary = 7000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "Veer",
                Salary = 5500
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "Mahii",
                Salary = 3500
            };
            //creating list - which can grow in size without throwing any exception
            List<Customer> listCustomers = new List<Customer>(2);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            //Contains() method
            //if(listCustomers.Contains(customer3)) 
            //Exists() method
            /*if (listCustomers.Exists(cust => cust.Name.StartsWith("J"))) 
            {
                Console.WriteLine("customer3 is present in the list");
            }
            else
            {
                Console.WriteLine("customer3 doesn't present in list");
            }*/
            //find() method - prints only first matching element
            //FindLast() - will print last matching item
            /*Customer c = listCustomers.FindLast(cust => cust.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID,c.Name,c.Salary);*/

            //FindAll() - will return list of customers statisfying the condition
            /*List<Customer> customers = listCustomers.FindAll(cust => cust.Salary > 5000);
            foreach (Customer c in customers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }*/

            //FindIndex method & we can overload that by adding the index befor lambda expression
            //FindLastIndex()
            int index = listCustomers.FindLastIndex(cust => cust.Salary > 5000);
            Console.WriteLine("Index = " +index);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}