using System;
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
                Salary = 4000,
                Type = "RetailCustomer"
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };
            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Johnny",
                Salary = 6500,
                Type = "CorporateCustomer"
            };
            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Shwan",
                Salary = 3500,
                Type = "CorporateCustomer"
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            //listCustomers.AddRange(listCorporateCustomers);
            /*foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID ={0}, Name= {1}, Salary= {2}, Type= {3}", c.ID, c.Name, c.Salary, c.Type);
            }*/
            //List<Customer> customers = listCustomers.GetRange(0, 3); //index no & items count you want

            //to insert the item in to the list
            listCustomers.InsertRange(3, listCorporateCustomers);
            // listCustomers.Remove(customer1);
            //listCustomers.RemoveAt(4); // index

            //listCustomers.RemoveAll(x => x.Type =="CorporateCustomer");
            listCustomers.RemoveRange(0,3);
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID ={0}, Name= {1}, Salary= {2}, Type= {3}", c.ID,c.Name,c.Salary,c.Type);
            }
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public string Type { get; set; }
    }
}