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
                Gender = "Male"
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Shwan",
                Gender = "Male"
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Sam",
                Gender = "Female"
            };
            Customer customer4 = new Customer()
            {
                Id = 104,
                Name = "Mike",
                Gender = "Female"
            };
            Customer customer5 = new Customer()
            {
                Id = 105,
                Name = "Jerry",
                Gender = "Female"
            };
            Stack<Customer> stackCustomer = new Stack<Customer>();
            stackCustomer.Push(customer1);
            stackCustomer.Push(customer2);
            stackCustomer.Push(customer3);
            stackCustomer.Push(customer4);
            stackCustomer.Push(customer5); //at the top


            /*Customer c1= stackCustomer.Pop();
            Console.WriteLine(c1.Id + " - " + c1.Name);
            Console.WriteLine("Items left in stack = " + stackCustomer.Count);

            Customer c2 = stackCustomer.Pop();
            Console.WriteLine(c2.Id + " - " + c2.Name);
            Console.WriteLine("Items left in stack = " + stackCustomer.Count);
            */
            //use foreach loop
            /*foreach (Customer c in  stackCustomer)
            {
                Console.WriteLine(c.Id + " - " + c.Name);
                Console.WriteLine("Items left in stack = " + stackCustomer.Count);
            }*/ // it will only show the items in LIFO manner not decrement the count as well
            
            /*Customer c1 = stackCustomer.Peek();//will show item at the top of stack without removing it
            Console.WriteLine(c1.Id + " - " + c1.Name);
            Console.WriteLine("Items left in stack = " + stackCustomer.Count);*/

            //to check wether the item present in stack or not use Contains()
            if (stackCustomer.Contains(customer4))
            {
                Console.WriteLine("Customer is present in stack");
            }
            else
            {
                Console.WriteLine("Customer doesn't present in stack");
            }

        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}