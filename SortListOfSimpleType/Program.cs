using System;
using System.Linq;
namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            List<int> numbers = new List<int>() {  1, 8, 7, 5, 2, 3, 4, 9, 6};
            Console.WriteLine("Numbers before sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }   
            numbers.Sort();
            Console.WriteLine("Numbers after sorting");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("Numbers in desending order");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alphabets = new List<string>() { "B", "E", "C", "A", "D" };
            Console.WriteLine("Numbers before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
            alphabets.Sort();
            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }

            alphabets.Reverse();
            Console.WriteLine("Alphabets in desending order");
            foreach (string alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }


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
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set;}
    }
}