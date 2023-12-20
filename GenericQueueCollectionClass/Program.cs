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
            Queue<Customer> queueCustomer = new Queue<Customer>();
            queueCustomer.Enqueue(customer1); //add items one after another
            queueCustomer.Enqueue(customer2);
            queueCustomer.Enqueue(customer3);
            queueCustomer.Enqueue(customer4);
            queueCustomer.Enqueue(customer5);

            /*Customer c = queueCustomer.Peek();
            Console.WriteLine("dequeued item= {0} & {1}", c.Id, c.Name);
            Console.WriteLine("Total items in queue= " + queueCustomer.Count);*/

            //Console.WriteLine("Total items in queue before dequeue= " + queueCustomer.Count);
            /*Customer c1= queueCustomer.Dequeue();
            Console.WriteLine("dequeued item= {0} & {1}",c1.Id, c1.Name);
            Console.WriteLine("Total items in queue= " + queueCustomer.Count); */ //instead use foreach loop

            /*foreach(Customer c in  queueCustomer)
            {
                Console.WriteLine("dequeued item= {0} & {1}", c.Id, c.Name);
                Console.WriteLine("Total items in queue= " + queueCustomer.Count);
            }*/

            if(queueCustomer.Contains(customer1))
            {
                Console.WriteLine("Customer1 is present in queue");
            }
            else
            {
                Console.WriteLine("Customer1 is not present in queue");
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