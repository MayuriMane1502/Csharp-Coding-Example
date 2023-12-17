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
                Salary = 5000
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "Mahii",
                Salary = 3500
            };
            //creating list - which can grow in size without throwing any exception
            List<Customer> customers = new List<Customer>(2);
           customers.Add(customer1);
           customers.Add(customer2);
           customers.Add(customer3);

            //we can insert the item at particular index using insert()
            customers.Insert(0, customer3);
            foreach(Customer c in customers)
            {
                Console.WriteLine(c.ID);
            }
            //Customer c = customers[0]; //it will give only one item detail
            //use for each loop to get details of all items present in the list
            /*foreach (Customer c in customers)
            {
                Console.WriteLine("Id= {0}, Name= {1}, Salary= {2}", c.ID, c.Name, c.Salary);
            }*/

            //also you can use for loop but need to specify the size
            for(int i = 0; i<customers.Count; i++)
            {
                Customer c = customers[i];
                Console.WriteLine("Id= {0}, Name= {1}, Salary= {2}", c.ID, c.Name, c.Salary);
            }

            
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}