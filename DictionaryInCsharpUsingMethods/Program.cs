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
            /*Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.Id, customer1);
            dictionaryCustomers.Add(customer2.Id, customer2);
            dictionaryCustomers.Add(customer3.Id, customer3);*/

            //converting array to dictionary
           /* Customer[] customers = new Customer[3];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3; */

            //list to dictionary
            List<Customer> customers = new List<Customer>();    
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);


            Dictionary<int,Customer> dict = customers.ToDictionary(cust => cust.Id, cust => cust);

            foreach(KeyValuePair<int,Customer> kvp in dict)
            {
                Console.WriteLine("Key ={0}", kvp.Key);
                Customer cust = kvp.Value;
                Console.WriteLine("ID ={0}, Name= {1}, Salary= {2}", cust.Id, cust.Name, cust.Salary);
            }

            /*Customer cust; // created refernce variable
            if(dictionaryCustomers.TryGetValue(101, out cust)) //TryGetValue bool-if the id is present it will print the result or print else part without showing error
            {
                Console.WriteLine("Id= {0}, Name ={1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The key is not found");
            }*/

            //to find the total no of items present in dictionary use count() method
           /*  Console.WriteLine("Total no of count present in dictionary - {0}", dictionaryCustomers.Count);//inbuilt method in dictionary
            Console.WriteLine("Total no of count present in dictionary - {0}", dictionaryCustomers.Count()); // count function
            Console.WriteLine("Total no of count present in dictionary whose salary > 40000 - {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 40000));

            //to remove the item from dictionary
            dictionaryCustomers.Remove(119);
            Console.WriteLine("Total no of count present in dictionary after removing item - {0}", dictionaryCustomers.Count); */
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}