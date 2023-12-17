using System;
using System.Collections.Generic;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mayuri",
                Salary = 50000
            };

            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Johnny",
                Salary = 70000
            };

            Customer customer3 = new Customer()
            {
                Id = 119,
                Name = "Mac",
                Salary = 35000
            };
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.Id, customer1);
            dictionaryCustomers.Add(customer2.Id, customer2);
            dictionaryCustomers.Add(customer3.Id, customer3);

            //to check wether the key is present or not
            if (!dictionaryCustomers.ContainsKey(customer1.Id))
            {
                dictionaryCustomers.Add(customer1.Id, customer3);
            }

            Customer customer119 = dictionaryCustomers[119];

            //Console.WriteLine("Id ={0}, Name = {1}, Salary = {2}", customer119.Id, customer119.Name,customer119.Salary);
            foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers) // KeyValuePair can be replace "var"
            {
                Console.WriteLine("Key ={0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name ={1}, Salary ={2}", cust.Id, cust.Name, cust.Salary);
                Console.WriteLine("-----------------------------------");
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}