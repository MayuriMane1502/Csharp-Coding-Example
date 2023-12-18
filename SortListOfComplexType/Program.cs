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

            Console.WriteLine("Before Sorting");
            foreach (Customer C in listCustomer)
            {
                Console.WriteLine(C.Salary);
                //Console.WriteLine(C.Name);
            }
            listCustomer.Sort();
            listCustomer.Reverse(); //salary in descending order
            Console.WriteLine("after Sorting");
            foreach (Customer C in listCustomer)
            {
                Console.WriteLine(C.Salary);
                //Console.WriteLine(C.Name);
            }

            SortByName sortByName = new SortByName();
            listCustomer.Sort(sortByName);
            Console.WriteLine("Sorting by Name");
            foreach (Customer C in listCustomer)
            {
                Console.WriteLine(C.Name);
                //Console.WriteLine(C.Name);
            }
        }
    }

    //you can also create class you want the item to be sorted
    //implement Icomparer interface
    public class SortByName: IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    } 
    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            /*if (this.Salary > other.Salary)
                return 1;
            else if(this.Salary < other.Salary)     return -1;
            else
                return 0;*/ 

            return this.Salary.CompareTo(other.Salary);
            //return this.Name.CompareTo(other.Name);
        }
    }
}