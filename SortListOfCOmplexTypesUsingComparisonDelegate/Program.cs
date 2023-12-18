using System;
using System.Linq;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 5500
            };

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer); // approach 1 method
            Console.WriteLine("Before Sorting");
            foreach(Customer c in listCustomer)
            {
                Console.WriteLine(c.ID);
            }
            //listCustomer.Sort(customerComparer); //approach -1
            //approach -2
           /* listCustomer.Sort(delegate (Customer c1, Customer c2)
            {
                return (c1.ID.CompareTo(c2.ID));
            }
            ); */

            //approach -3

            listCustomer.Sort((c1,c2) => c1.ID.CompareTo(c2.ID));
            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.ID);
            }
        }
        /*private static int CompareCustomer(Customer x, Customer y) // approach 1 part
        {
            return x.ID.CompareTo(y.ID);
        }*/

       
    }

    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}